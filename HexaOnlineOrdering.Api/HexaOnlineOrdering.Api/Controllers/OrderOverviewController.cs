using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Utils;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Enums;
using HexaOnlineOrdering.Models.Notification;
using HexaOnlineOrdering.Models.Orders;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Controllers
{

    [Route("api/[controller]")]
    public class OrderOverviewController : BaseController
    {
        private readonly IProductService _productService; // for getting detail
        private readonly INetforceService _netforceService; // for getting order status
        private readonly IOrdersService _orderOverviewService; // for gettubg detail
        private readonly IUserService _userService;
        private readonly ICaseService _caseService;
        private readonly INotificationService _notificationService;

        public OrderOverviewController(IUserService userService,IHttpContextAccessor httpContextAccessor, INotificationService notificationService, IOrdersService orderService , IProductService productService, INetforceService netforceService, ICaseService caseService) : base(httpContextAccessor)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _netforceService = netforceService ?? throw new ArgumentNullException(nameof(netforceService));
            _orderOverviewService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _caseService = caseService ?? throw new ArgumentNullException(nameof(caseService));
            _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
        }

        [Authorize(Roles = "Dentist,Clinic")]
        [HttpGet("GetOrdersByClinicId/{clinicId}")]
        public async Task<OrderWithLengthModel> GetOrdersByClinicId([FromRoute] int clinicId
            , DateTime from
            , DateTime to
            , int[] status
            , int searchType
            , string searchStr
            , int page
            , int pageSize
            , int dentistId
            , int productTypeId
            , string sortOrder)
        {
            // TODO : implement using filter from query string 

            OrderWithLengthModel result = await _orderOverviewService.GetOrderListByClinictId(clinicId
            , from
            , to
            , status
            , searchType
            , searchStr ?? ""
            , page
            , pageSize
            , dentistId
            , productTypeId
            , sortOrder);

            if (result == null)
            {
                throw new HexaDomainException("Get orders error.");
            }

            return result;
        }

        [Authorize(Roles = "Dentist,Clinic")]
        [HttpGet("GetOrdersByDentistId/{dentistId}")]
        public async Task<OrderWithLengthModel> GetOrdersByDentistId([FromRoute] int dentistId
            , DateTime from
            , DateTime to
            , List<int> status
            , int searchType
            , string searchStr
            , int page
            , int pageSize
            , int clinicId
            , int productTypeId
            , string sortOrder)
        {
            // if some of parameter is null means there is no data sent from client

            OrderWithLengthModel result = await _orderOverviewService.GetOrderListByDentistId(
              dentistId
            , from
            , to
            , status
            , searchType
            , searchStr ?? ""
            , page
            , pageSize
            , clinicId
            , productTypeId
            , sortOrder);

            if (result == null)
            {
                throw new HexaDomainException("Get orders error.");
            }

            return result;
        }

        [Authorize(Roles = "Dentist,Clinic")]
        [HttpDelete("DeleteOrder/{orderId}")]
        public async Task<int> DeleteOrderById([FromRoute] int orderId)
        {
            int id = await _orderOverviewService.DeleteOrder(orderId);
            if(id == -1)
            {
                // delete error 
                throw new HexaDomainException("Delete order error.");
            }
            return orderId;
        }

        [Authorize(Roles = "Dentist,Clinic,Admin,Staff")]
        [HttpGet("GetOrderDetail/{orderId}")]
        public async Task<DisplayOrderDetail> GetOrderDetailById([FromRoute] int orderId)
        {
            DisplayOrderDetail result = await _orderOverviewService.GetOrderDetailById(orderId);

            if (result == null || result.OrderDetail == null || result.CaseOrderLists == null)
            {
                throw new HexaDomainException("Get order detail error.");
            }

            return result;
        }

        [Authorize(Roles = "Dentist,Clinic")]
        [HttpPatch("CancelOrder/{orderId}")]
        public async Task<int> CancelOrder([FromRoute] int orderId)
        {
            int id = await _orderOverviewService.CancelOrder(orderId);
            if(id == -1)
            {
                // cancel order error 
                throw new HexaDomainException("Cancel order error.");
            }
            return orderId;
        }


        [Authorize(Roles = "Admin,Staff")]
        [HttpGet("GetAllOrders")]
        public async Task<OrderWithLengthModel> GetAllOrders([FromQuery] OrderFilterModel order)
        {

            if (order == null)
            {
                throw new HexaDomainException("Admin get order list error.");
            }

            List<int> permissionList = await GetAdminPermission();
            OrderWithLengthModel orderWithLengthModel = await _orderOverviewService.GetAllOrders(order,permissionList);        

            if (orderWithLengthModel.OrderList == null)
            {
                throw new HexaDomainException("Admin get order list error.");
            }

            return orderWithLengthModel;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpGet("GetOrderReports")]
        public async Task<List<AdminReportModel>> GetOrderReports([FromQuery] OrderFilterModel order)
        {

            if (order == null)
            {
                throw new HexaDomainException("Admin get order report error.");
            }

            List<int> permissionList = await GetAdminPermission();
            List<AdminReportModel> reportModel = await _orderOverviewService.GetOrdersReport(order,permissionList);

            if (reportModel == null)
            {
                throw new HexaDomainException("Admin get order report error.");
            }

            return reportModel;
        }


        [Authorize(Roles = "Admin,Staff")]
        [HttpPut("UpdateEstimated")]
        public async Task<bool> UpdateEstimated([FromBody] UpdateEstimatedDateRequest request)
        {

            if (request == null)
            {
                throw new HexaDomainException("Update Expected Delivery Date error, Bad request model");
            }
            else if(request.OrderId < 1)
                throw new HexaDomainException("Update Expected Delivery Date error, Bad request Oeder Id");
            else if(request.EstimatedDate == default)
                throw new HexaDomainException("Update Expected Delivery Date error, Bad request Expected Delivery Date");

            string errorText = await _orderOverviewService.UpdateEstimatedDate(request);

            if (!string.IsNullOrEmpty(errorText))
            {
                throw new HexaDomainException(errorText);
            }

            return true;
        }

        [Authorize()]
        [HttpPost("ExportPdf")]
        public async Task<FileContentResult> ExportOrderToPdf([FromBody] int[] request)
        {
            if (request == null)
            {
                throw new HexaDomainException("No request body, Bad request data");
            }

            if (request.Length < 1)
            {
                throw new HexaDomainException("request length < 1, Bad request data");
            }

            // get order detail list

            List<DisplayOrder> orderDetails = await _orderOverviewService.GetPrintingOrderList(request.ToList());

            byte[] pdfBuffer = _orderOverviewService.GetOrderPDFBuffer(orderDetails);
            string fileName = $"Order_{DateTime.UtcNow.Ticks.ToString()}";

            return File(pdfBuffer, "application/pdf", fileName);
        }
        [Authorize(Roles = "Dentist,Clinic,Admin,Staff")]
        [HttpPatch("UpdateOrderStatus")]
        public async Task<OrderModel> UpdateOrderStatus([FromBody] DisplayOrderStatus order)
        {
            if( order == null)
            {
                throw new HexaDomainException("Update Order status error, Bad request order");
            }

            if (order.OrderStatusId < 1)
            {
                throw new HexaDomainException("Update Order status error");
            }

            UserModel user = await _userService.GetUserById(CurrentUserId);

            if(user == null)
            {
                throw new HexaDomainException("No user, Bad request data");
            }

            //send notification when admin changed
            Role userRole = _userService.GetRoleEnumById(user.UserRoleId);
            bool isAdmin = (userRole != Role.DENTIST && userRole != Role.CLINIC);

            //user change status send admin's flag
            OrderModel result = await _orderOverviewService.UpdateOrderStatusIcharm(order.caseId, order.OrderStatusId, !isAdmin);

            if( result == null)
            {
                throw new HexaDomainException("Update Order failed");
            }

            if (isAdmin)
            {
                //send 
                OrderDetailModel orderNoti = await _orderOverviewService.GetOrderByCaseId(order.caseId);

                ReceiveNotificationModel notificationModel = GenerateIcharmNotificationMessage(orderNoti, order.OrderStatusId);
                if(notificationModel != null && !string.IsNullOrEmpty(notificationModel.Message))
                    await _notificationService.CreateNotificationAsync(orderNoti.UserId, notificationModel);
            }
           

            return result;
        }

        [Authorize(Roles = "Dentist,Clinic,Admin,Staff")]
        [HttpPatch("UpdateOrderAligners")]
        public async Task<CaseModel> UpdateOrderAligners([FromBody] OrderAligners request)
        {
            if (request == null)
            {
                throw new HexaDomainException("Update Order Aligners error, Bad request order");
            }

            if (request.CaseId < 1)
            {
                throw new HexaDomainException("Update Order Aligners error");
            }

            CaseModel result = await _caseService.UpdateCaseAlignersIcharm(request.CaseId, request.Aligners);

            if (result == null)
            {
                throw new HexaDomainException("Update Aligners failed");
            }

            return result;
        }

        [Authorize(Roles = "Dentist,Clinic,Admin,Staff")]
        [HttpPatch("UpdateOrderMemo")]
        public async Task<CaseModel> UpdateMemo([FromBody] OrderMemo request)
        {
            if (request == null)
            {
                throw new HexaDomainException("Update memo error, Bad request order");
            }

            if (request.CaseId < 1)
            {
                throw new HexaDomainException("Update memo error");
            }

            CaseModel result = await _caseService.UpdateCaseMemoIcharm(request.CaseId, request.Memo);

            if (result == null)
            {
                throw new HexaDomainException("Update memo failed");
            }

            return result;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpPatch("UpdateLevelOfTreatment")]
        public async Task<CaseProductModel> UpdateLevelOfTreatment([FromBody] OrderLevelOfTreatment request)
        {
            if (request == null)
            {
                throw new HexaDomainException("Update case product error, Bad request order");
            }

            if (request.CaseId < 1)
            {
                throw new HexaDomainException("Update case product error");
            }

            CaseProductModel result = await _caseService.UpdateCaseProductIcharm(request.CaseId, request.ProductId, request.NotificationText);

            if (result == null)
            {
                throw new HexaDomainException("Update case product failed");
            }

            return result;
        }
 
        [Authorize(Roles = "Admin,Staff")]
        [HttpPatch("UpdateOrderNotification")]
        public async Task<OrderModel> UpdateOrderIsNotification([FromBody] DisplayOrderIsNotification order)
        {
            var result = await _orderOverviewService.UpdateOrderIsNotification(order.orderId, order.IsNotification);

            if (result == null)
            {
                throw new HexaDomainException("Update Order isNotification failed");
            }

            return result;
        }

        private async Task<List<int>> GetAdminPermission()
        {
            UserModel user = await _userService.GetUserById(CurrentUserId);
            if(user != null)
            {
                Role userRole = _userService.GetRoleEnumById(user.UserRoleId);
                if(userRole != Role.DENTIST && userRole != Role.CLINIC && userRole != Role.ADMIN)
                {
                    return user.AdminProductTypeId;
                }
                return new List<int>();
               
            }
            return null;
            
        }

        private ReceiveNotificationModel GenerateIcharmNotificationMessage(OrderDetailModel order, int orderStatusId)
        {
            ReceiveNotificationModel notificationModel = new ReceiveNotificationModel();
            notificationModel.Message = GenerateIcharmNotificationMessage(order.OrderRef, (IcharmOrderStatusEnum)orderStatusId, order.PatientName);
            notificationModel.Title = " สถานะ order เปลี่ยนแปลง ";
            notificationModel.userId = order.UserId;

            return notificationModel;
        }
        private string GenerateIcharmNotificationMessage(string referenceNumber, IcharmOrderStatusEnum orderStatus, string patientName)
        {
            string orderMessage = IcharmStatusMessage(orderStatus);
            if (string.IsNullOrEmpty(orderMessage))
            {
                return string.Empty;
            }

            string orderReferenceMessage = string.Format("Order {0}", referenceNumber);
            orderReferenceMessage = string.Format("{0}\nคนไข้คุณ {1} ", orderReferenceMessage, patientName);

            orderReferenceMessage = string.Format("{0}\n{1} ", orderReferenceMessage, orderMessage);

            //MessageUtil messageUtil = new MessageUtil();
            //DateTime thaiTime = messageUtil.ToThaiTime(DateTime.Now);
            //orderReferenceMessage = string.Format("{0}\nวันที่:{1} เวลา:{2}", orderReferenceMessage, thaiTime.ToString("dd MMM yyyy"), thaiTime.ToString("HH:mm"));


            return orderReferenceMessage;
        }

        private string IcharmStatusMessage(IcharmOrderStatusEnum orderStatus)
        {
            switch (orderStatus)
            {
                case IcharmOrderStatusEnum.WaitingOrder:
                    return "ได้รับการ Accepted และมีการส่ง Case Presentation แล้ว";
                case IcharmOrderStatusEnum.Step1:
                    return "ได้รับการยืนยันเพื่อเริ่มต้นการผลิตใน 1st set เแล้ว";
                case IcharmOrderStatusEnum.Delivery:
                    return "ได้รับการยืนยันเพื่อจัดส่ง 1st set เแล้ว";
                case IcharmOrderStatusEnum.Step2:
                    return "ได้รับการยืนยันเพื่อเริ่มต้นการผลิตใน 2nd set เแล้ว";
                case IcharmOrderStatusEnum.Completed:
                    return "ได้รับการยืนยันเพื่อจัดส่ง 2nd set เแล้ว";
                case IcharmOrderStatusEnum.Reject:
                    return string.Format("ถูกยกเลิก.");
                default:
                    return string.Empty;
            }
        }



    }
}
