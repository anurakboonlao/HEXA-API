using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Filters;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Utils;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Notification;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HexaOnlineOrdering.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : BaseController
    {
        private readonly INotificationService _notiService;
        private readonly IOrdersService _orderService;
        private readonly ICaseService _caseService;
        private readonly INotificationService _notificationService;
        private readonly IEmailService _emailService;
        private readonly IUserService _userService;
        public NotificationController(IHttpContextAccessor httpContextAccessor, IUserService userService, IEmailService emailService, INotificationService notificationService, ICaseService caseService, INotificationService notiService, IOrdersService orderService) : base(httpContextAccessor)
        {
            _notiService = notiService ?? throw new ArgumentNullException(nameof(notiService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _caseService = caseService ?? throw new ArgumentNullException(nameof(caseService));
            _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [CustomAuthorization]
        [HttpPost("updatestatus")]
        public async Task<UpdateOrderStatusResponseModel> UpdateOrderStatus([FromBody] UpdateOrderStatusModel updateOrder)
        {
            UpdateOrderStatusResponseModel result = new UpdateOrderStatusResponseModel();

            // 1. Get order from Ref
            // 2. If not found return error
            // 3. Update the status compare to the status from ERP and TblOrderStatus
            // 4. create notification
            // 5. send email to user

            OrderDetailModel order = await _orderService.GetOrderByReference(updateOrder.ReferenceNumber);
            if (order == null)
            {
                result.Error = "The Reference Number cannot be found.";
                return result;
            }

            if (string.IsNullOrEmpty(updateOrder.Status))
            {
                result.Error = "The Status is not defined.";
                return result;
            }

            switch (updateOrder.Status)
            {
                case "draft":
                    order.Status = 1;
                    break;
                case "wait":
                    order.Status = 2;
                    break;
                case "order":
                    order.Status = 3;
                    break;
                case "delivery":
                    order.Status = 5;
                    break;
                case "done":
                    order.Status = 6;
                    break;
                case "voided":
                    order.Status = 7;
                    break;
                default:
                    return new UpdateOrderStatusResponseModel() { Error = $"Status is not correct for {updateOrder.Status}" };
            }

            await _orderService.UpdateOrderStatus(order.Id, order.Status);
            DisplayCaseModel caseModel = await _caseService.GetCaseByCaseId(order.CaseId);
                
            if (caseModel == null)
            {
                result.Error = "Case not found, can not update notification.";
                return result;
            }

            /// Send notification only status Accepted or Rejected
            bool isSandNotification = order.Status == (int)OrderStatusEnum.ordered || order.Status == (int)OrderStatusEnum.reject;

            if (isSandNotification)
            {
                ReceiveNotificationModel notificationModel = new ReceiveNotificationModel();
                notificationModel.Message = GenerateNotificationMessage(order.OrderRef, (OrderStatusEnum)order.Status, caseModel.PatientName);
                notificationModel.Title = " สถานะ order เปลี่ยนแปลง ";
                notificationModel.userId = caseModel.UserId;

                int createNotiResult = await _notificationService.CreateNotificationAsync(caseModel.UserId, notificationModel);

                if (createNotiResult > 0)
                {
                    result.Result = "Update status success with send notification.";
                }
                else
                {
                    result.Error = "Send notification error.";
                }
                return result;
            }

            result.Result = "Update status success.";
            return result;
        }

        private string GenerateNotificationMessage(string referenceNumber, OrderStatusEnum orderStatus, string patientName)
        {
            string orderReferenceMessage = string.Format("Order {0}", referenceNumber);
            orderReferenceMessage = string.Format("{0}\nคนไข้คุณ {1} ", orderReferenceMessage, patientName);

            if (orderStatus == OrderStatusEnum.ordered)
            {
                return string.Format("{0}\nได้รับเรียบร้อยแล้ว.", orderReferenceMessage);
            }

            switch (orderStatus)
            {
                case OrderStatusEnum.ordered:
                    return string.Format("{0}\nได้รับเรียบร้อยแล้ว.", orderReferenceMessage);                  
                case OrderStatusEnum.reject:
                    return string.Format("{0}\nถูกยกเลิก.", orderReferenceMessage);
                default:
                    return string.Empty;
            }       
        }

        [Authorize()]
        [HttpGet("GetNotification/{userId}")]
        public async Task<DisplayNotificationWithTotal> GetNotificationById([FromRoute] int userId, int limit)
        {
            List<DisplayNotification> displayNotification = new List<DisplayNotification>();
            displayNotification = await _notiService.GetNotificationByIdAsync(userId, limit);
            int total = await _notiService.GetTotalNotificationsAsync(userId);

            DisplayNotificationWithTotal displayNotificationWithTotal= new DisplayNotificationWithTotal();
            displayNotificationWithTotal.Notification = displayNotification;
            displayNotificationWithTotal.TotalNotification = total;
            return displayNotificationWithTotal;
        }

        [Authorize()]
        [HttpPost("ReadNotification/{notiId}")]
        public async Task<int> ReadNotification([FromRoute] int notiId)
        {

            int result = await _notiService.ReadNotificationAsync(notiId);

            if (result == -1)
            {
                throw new HexaDomainException("Can not read notification");
            }
            return notiId;
        }

        [Authorize()]
        [HttpPost("CreateNotification/{userId}")]
        public async Task<int> CreateNotification(int userId, [FromBody] ReceiveNotificationModel notiModel)
        {
            // TODO : Implement create notificaiton

            int result = await _notiService.CreateNotificationAsync(userId, notiModel);

            if (result == -1)
            {
                throw new HexaDomainException("Can create notification");
            }
            return userId;
        }
    }
}