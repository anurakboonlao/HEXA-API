using HexaOnlineOrdering.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.Interfaces;
using System.Diagnostics;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Api.Extensions;
using AutoMapper;
using HexaOnlineOrdering.Models.Notification;
using HexaOnlineOrdering.Models.Orders;
using HexaOnlineOrdering.Models.Marketing;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using HexaOnlineOrdering.Api.Options;
using Microsoft.Extensions.Options;
using HexaOnlineOrdering.Api.Utils;
using DinkToPdf.Contracts;
using HexaOnlineOrdering.Models.Enums;

namespace HexaOnlineOrdering.Api.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrderOverviewRepository _orderRepo;
        private readonly ICaseRepository _caseRepo;
        private readonly IProductTypeRepository _productTypeRepo;
        private readonly IMapper _mapper;
        private readonly INetforceService _netforceService;
        private readonly IAWS3service _aws3Service;
        private readonly INotificationService _notificationService;
        private readonly IUserService _userService;
        private readonly ICaseService _caseService;
        private readonly IEmailService _emailService;
        private readonly IMarketingService _marketingService;
        private readonly ISmsService _smsService;
        private readonly ILogger<OrdersService> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOptions<HostSetting> _hostSetting;
        private readonly IConverter _converter;
        private readonly IOptions<PdfSetting> _pdfSetting;
        public OrdersService(IOrderOverviewRepository orderRepo, ISmsService smsService, IMarketingService marketingService, IEmailService emailService, ICaseService caseService, IUserService userService, IAWS3service aws3Service, ICaseRepository caseRepo, IProductTypeRepository productTypeRepo, IMapper mapper, INetforceService netforceService, INotificationService notificationService, ILogger<OrdersService> logger,IHttpContextAccessor httpContextAccessor, IOptions<HostSetting> hostSetting, IConverter converter, IOptions<PdfSetting> pdfSetting)
        {
            _orderRepo = orderRepo ?? throw new ArgumentNullException(nameof(orderRepo));
            _caseRepo = caseRepo ?? throw new ArgumentNullException(nameof(caseRepo));
            _productTypeRepo = productTypeRepo ?? throw new ArgumentNullException(nameof(productTypeRepo));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _netforceService = netforceService ?? throw new ArgumentNullException(nameof(netforceService));
            _aws3Service = aws3Service?? throw new ArgumentNullException(nameof(aws3Service));
            _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _caseService = caseService ?? throw new ArgumentNullException(nameof(caseService));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            _marketingService = marketingService ?? throw new ArgumentNullException(nameof(marketingService));
            _smsService = smsService ?? throw new ArgumentNullException(nameof(smsService));
            _httpContextAccessor = httpContextAccessor;
            _hostSetting = hostSetting;
            _converter = converter;
            _logger = logger;
            _pdfSetting = pdfSetting;
        }

        public OrderModel GetOrder(int orderId)
        {
            TblOrder model  = _orderRepo.Get(o => o.Id == orderId);

            return model.MapTo<OrderModel>();
        }
        public async Task<OrderModel> CreateOrder(int caseId, string referenceNumber, DateTime? EstimatedDate, bool isNotification = false)
        {
            TblOrder model = new TblOrder();
            model.CaseId = caseId;
            model.ReferenceNumber = referenceNumber;
            model.OrderDate = DateTime.Now;
            model.OrderStatusId = 1;
            model.EstimatedDate = EstimatedDate;
            model.Disabled = false;
            model.IsNotification = isNotification;

            await _orderRepo.AddAsync(model);
            await _orderRepo.CommitAsync();
            return model.MapTo<OrderModel>();
        }

        public async Task<int> DeleteOrder(int orderId)
        {
            return await _orderRepo.DeleteOrderById(orderId);
        }

        public async Task<string> GetNewOrderReferenceNumber(bool isSitMode)
        {
            DateTime currentDate = DateTime.Now.Date;
            int counter = await _orderRepo.GetCurrentReferenceNumber(currentDate);
            string prefix = "OL";
            if (isSitMode)
                prefix = "OLSIT";
            string result = string.Format("{0}{1}{2}", prefix, currentDate.ToString("yyyyMMdd"), (counter + 1).ToString().PadLeft(5, '0'));
            return result;
        }

        public async Task<OrderWithLengthModel> GetOrderListByClinictId(int clinicId
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
            List<int> statusList = new List<int>(status);

            // step 1
            List<DisplayOrder> displayOrders = await _orderRepo.GetClinicOrdersFilterByDateAndStatus(from,to, statusList, clinicId, dentistId);

            if (displayOrders == null)
            {
                return null;
            }

            // step 2
            displayOrders = await FillNameWithERP(displayOrders);

            displayOrders = getOrdersWithFilterByProductType(displayOrders, productTypeId);

            // step 3
            displayOrders = getOrdersWithFilter(displayOrders, searchType, searchStr, SearchRoleEnum.clinic);

            // step 4
            int total = displayOrders.Count;

            // step 5
            displayOrders = sortOrderByType(sortOrder, displayOrders);

            // step 6
            displayOrders = displayOrders.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            OrderWithLengthModel orderWithLengthModel = new OrderWithLengthModel();
            orderWithLengthModel.Total = total;
            orderWithLengthModel.OrderList = displayOrders;

            return orderWithLengthModel;
        }

        public async Task<OrderWithLengthModel> GetOrderListByDentistId(int dentistId
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

            // step 1
            List<DisplayOrder> displayOrders = await _orderRepo.GetDentistOrdersFilterByDateAndStatus(from, to, status, dentistId, clinicId );

            if (displayOrders == null)
            {
                return null;
            }

            // step 2
            displayOrders = await FillNameWithERP(displayOrders);

            displayOrders = getOrdersWithFilterByProductType(displayOrders, productTypeId);
            // step 3
            displayOrders = getOrdersWithFilter(displayOrders, searchType, searchStr, SearchRoleEnum.clinic);

            // step 4
            int total = displayOrders.Count;

            // step 5
            displayOrders = sortOrderByType(sortOrder, displayOrders);

            // step 6
            displayOrders = displayOrders.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            OrderWithLengthModel orderWithLengthModel = new OrderWithLengthModel();
            orderWithLengthModel.Total = total;
            orderWithLengthModel.OrderList = displayOrders;

            return orderWithLengthModel;
        }

        public async Task<DisplayOrderDetail> GetOrderDetailById(int orderId)
        {
            DisplayOrderDetail displayOrderDetail = new DisplayOrderDetail();

            // 1. get order detail model
            OrderDetailModel order = await _orderRepo.GetOrderDetail(orderId);
            if(order?.PathAttachedFiles?.Count > 0)
            {
                foreach (DisplayAttachFile file in order.PathAttachedFiles)
                {
                    file.FilePath = _aws3Service.GenerateAwsFileUrl(file.FilePath);
                }
            }

            // 1.1 get doctor detail         
                MarketingMemberModel doctorDetail = await _marketingService.GetMemberByCustomerId(order.DoctorId);
                if (doctorDetail != null)
                {
                    order.Doctor = doctorDetail;
                }
            // 1.2 get clinic detail         
                MarketingMemberModel clinicDetail = await _marketingService.GetMemberByCustomerId(order.ClinicId);
                if (clinicDetail != null)
                {
                    order.Clinic = clinicDetail;
                }

            displayOrderDetail.OrderDetail = order;

            // 2. get order small detail (list)
            displayOrderDetail.CaseOrderLists = await _orderRepo.GetOrderSmallDetailList(orderId);

            return displayOrderDetail;

        }

        public async Task<int> CancelOrder(int orderId)
        {

            OrderDetailModel orderDetailModel = await _orderRepo.GetOrderDetail(orderId);

            if(orderDetailModel == null && orderDetailModel.OrderRef != string.Empty)
            {
                return -1;
            }

            try
            {
                await _netforceService.CancelOrder(orderDetailModel.OrderRef);
            }
            catch (HexaDomainException)
            {
                return -1;
            }
            
            return await _orderRepo.CancelOrder(orderId);
        }


        public async Task<DashboardModel> GetClinicDashboard(int clinicId, DateTime startDate, DateTime endDate, int dentistId)
        {
            List<TblCase> cases = await _caseRepo.GetClinicCaseForDashboard(clinicId, startDate, endDate, dentistId);
            List<TblOrder> corders = await _orderRepo.GetClinicOrderForDashboard(clinicId, startDate, endDate, dentistId);
            List<ProductGroupModel> productsInGroup = await _productTypeRepo.GetAllProductGroupModel();
            DashboardModel model = CreateDashboardModel(cases, corders, startDate, endDate, productsInGroup);
            return model;
        }
        public async Task<DashboardModel> GetDentistDashboard(int dentistId, DateTime startDate, DateTime endDate, int clinicId)
        {
            List<TblCase> cases = await _caseRepo.GetDentistCaseForDashboard(dentistId, startDate, endDate, clinicId);
            List<TblOrder> corders = await _orderRepo.GetDentistOrderForDashboard(dentistId, startDate, endDate, clinicId);
            List<ProductGroupModel> productsInGroup = await _productTypeRepo.GetAllProductGroupModel();
            DashboardModel model = CreateDashboardModel(cases, corders, startDate, endDate, productsInGroup);
            return model;
        }

        public async Task<DashboardModel> GetAdminDashboard( DateTime startDate, DateTime endDate)
        {
            List<TblOrder> corders = await _orderRepo.GetOrderForAdminDashboard(startDate, endDate);
            List<ProductGroupModel> productsInGroup = await _productTypeRepo.GetAllProductGroupModel();
            DashboardModel model = CreateDashboardModel(null, corders, startDate, endDate, productsInGroup);
            return model;
        }

        public async Task<OrderDetailModel> GetOrderByReference(string reference)
        {
            OrderDetailModel model = await _orderRepo.GetOrderDetail(reference);
            return model;
        }

        public async Task<OrderDetailModel> GetOrderByCaseId(int caseId)
        {
            OrderDetailModel model = await _orderRepo.GetOrderDetailByCasedId(caseId);
            return model;
        }

        public async Task UpdateOrderStatus(int orderId, int statusId)
        {
            var order = await _orderRepo.GetAsync(c => c.Id == orderId);
            if (order != null)
            {
                order.OrderStatusId = statusId;
                if(statusId == 3 && !order.EstimatedDate.HasValue)
                {
                    DateTime? estimatedDate = await _orderRepo.CalculateEstimatedDate(orderId);
                    if (estimatedDate.HasValue)
                        order.EstimatedDate = estimatedDate.Value;

                }
                   
                _orderRepo.Update(order);
                await _orderRepo.CommitAsync();
            }
        }

        public async Task<OrderModel> UpdateOrderStatusIcharm(int caseId, int statusId, bool isNotification)
        {
            TblOrder order = await _orderRepo.GetAsync(c => c.CaseId == caseId);

            if( order != null)
            {
                if (order.OrderStatusId == statusId)
                {
                    throw new HexaDomainException("Update order status error, Bad request statusId");
                }

                order.OrderStatusId = statusId;
                order.IsNotification = isNotification;

                _orderRepo.Update(order);
                await _orderRepo.CommitAsync();
                
            }

            return _mapper.Map<TblOrder, OrderModel>(order);
        }

        public async Task<OrderModel> UpdateOrderIsNotification(int orderId, bool isNotification)
        {
            TblOrder order = await _orderRepo.GetAsync(c => c.Id == orderId);

            if (order == null)
            {
                throw new HexaDomainException("No update order IsNotification, Bad request orderId");
            }

            order.IsNotification = isNotification;

           _orderRepo.Update(order);
           await _orderRepo.CommitAsync();
            

            return _mapper.Map<TblOrder, OrderModel>(order);
        }

        public async Task<List<AdminReportModel>> GetOrdersReport(OrderFilterModel orderFilter, List<int> adminPermission)
        {
            List<AdminReportModel> reports = await _orderRepo.GetOrdersReportFilterByDate(orderFilter.FromDate, orderFilter.ToDate, orderFilter.Status, adminPermission);

            if (reports?.Count > 0)
            {
                List<int> dentistIds = new List<int>();
                List<int> clinicIds = new List<int>();

                List<ERP.Models.DoctorModel> doctors = null;
                List<ERP.Models.ContactModel> clinics = null;

                dentistIds = reports.Select(s => s.DentistId).Distinct().ToList();
                clinicIds = reports.Select(s => s.ClinicId).Distinct().ToList();

                if (dentistIds?.Count > 0)
                    doctors = await _netforceService.GetDoctorByIdsAsync(dentistIds);
                if (clinicIds?.Count > 0)
                    clinics = await _netforceService.GetContactByIdsAsync(clinicIds);

                foreach (AdminReportModel report in reports)
                {
                    report.ClinicName = clinics.Find(d => d.Id == report.ClinicId)?.Name;
                    report.DentistName = doctors.Find(d => d.Id == report.DentistId)?.Name;
                }
            }

            return reports;
        }

        public async Task<OrderWithLengthModel> GetAllOrders(OrderFilterModel orderFilter, List<int> adminPermission)
        {
            /*
             * * * * * * * * * * * * * * * * * * * 
             *  Step to query and filter order   *
             * * * * * * * * * * * * * * * * * * * 
             * 
             *  1. filter by date,status (where) 
             *  2. fill clinic/dentist name with ERP
             *  3. filter with Product Type 
             *  4. filter by search string
             *  5. count total
             *  6. sort 
             *  7. skip,take ( paging )
             */

            // step 1 
            List<DisplayOrder> displayOrders = await _orderRepo.GetOrdersFilterByDateAndStatus(orderFilter.FromDate, orderFilter.ToDate, orderFilter.Status);

            if (displayOrders == null)
            {
                return null;
            }

            // step 2
            displayOrders = await FillNameWithERP(displayOrders);

            // step 3 
            displayOrders = getOrdersWithFilterByProductType(displayOrders, orderFilter.ProductTypeId);

            if(adminPermission?.Count > 0)
            {
                //filter staff permission out
                displayOrders = getOrdersWithFilterByProductTypes(displayOrders, adminPermission);
            }

            // step 4
            displayOrders = getOrdersWithFilter(displayOrders, orderFilter.SearchType, orderFilter.SearchStr, SearchRoleEnum.all);

            // step 5
            int total = displayOrders.Count;

            // step 6
            displayOrders = sortOrderByType(orderFilter.sortOrder, displayOrders);

            // step 7
            displayOrders = displayOrders.Skip((orderFilter.Page - 1) * orderFilter.PageSize).Take(orderFilter.PageSize).ToList();

            OrderWithLengthModel orderWithLengthModel = new OrderWithLengthModel();
            orderWithLengthModel.Total = total;
            orderWithLengthModel.OrderList = displayOrders;

            return orderWithLengthModel;
        }

        public async Task<List<DisplayOrder>> GetPrintingOrderList(List<int> orderIds)
        {
            /*
             * * * * * * * * * * * * * * * * * * * 
             *  Step to query and filter order   *
             * * * * * * * * * * * * * * * * * * * 
             * 
             *  1. filter by idss (where) 
             *  2. fill clinic/dentist name with ERP 
             */

            List<DisplayOrder> displayOrders = await _orderRepo.GetOrderDisplayByIds(orderIds);
            if (displayOrders == null)
            {
                return null;
            }

            // step 2
            displayOrders = await FillNameWithERP(displayOrders);

            return displayOrders;

        }

        public byte[] GetOrderPDFBuffer(List<DisplayOrder> orderData)
        {
            OrderCardPrinting htmlPrinting = new OrderCardPrinting();
            string orderHtml = htmlPrinting.GetDocumentHtml(orderData);

            var request = _httpContextAccessor.HttpContext.Request;
            string baseUrlPattern = $"http[s]?:\\/\\/{request.Host}";

            //Note:: Check if Host by IP baseUrlPattern will include Port
            Match match = Regex.Match(_hostSetting.Value.Host ?? "", @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            if (match.Success)
            {
                baseUrlPattern = $"http[s]?:\\/\\/{_hostSetting.Value.Host}:{_hostSetting.Value.Port}";
            }
            _logger.LogInformation($"Info: Base url pattern -> {baseUrlPattern}");

            var connection = _httpContextAccessor.HttpContext.Connection;
            string localUrl = $"{request.Scheme}://localhost:{connection.LocalPort}";
            _logger.LogInformation($"Info: Local url -> {localUrl}");

            // Replace baseUrl to localUrl
            string newHtml = Regex.Replace(orderHtml, baseUrlPattern, localUrl);
            _logger.LogInformation($"Info: New html -> {newHtml}");

            _logger.LogInformation($"BEGIN : Convert certificate to PDF by Html : {newHtml}");
            PdfConvertor convertor = new PdfConvertor(_converter, _pdfSetting);
            byte[] pdfBuffer = convertor.ConvertHtmlToPDF(newHtml);

            return pdfBuffer;
        }

        #region Private Methods
        private DashboardModel CreateDashboardModel(List<TblCase> cases, List<TblOrder> orders, DateTime startDate, DateTime endDate, List<ProductGroupModel> productGroupModels)
        {
            DashboardModel model = new DashboardModel();
            List<DateTime> dates = new List<DateTime>();
            for (DateTime dt = startDate.Date; dt <= endDate.Date; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }
            model.DateList = dates;
            model.AllGroupsOfProduct = productGroupModels.Select(group=>new ProductGroupModel() { Id = group.Id,Name = group.Name, OrderNumber = group.OrderNumber, ProductTypeId = group.ProductTypeId }).ToList();
            if (model.DateList?.Count > 0)
            {
                //Add case count
                if (cases?.Count > 0)
                {
                    List<DashboardCaseCount> tempCaseCount = cases.GroupBy(c => c.CreatedDate.Date, (key, g) => new DashboardCaseCount() { Date = key, CaseCount = g.Count() }).ToList();
                    List<DashboardCaseCount> caseCount = new List<DashboardCaseCount>();
                    foreach (DateTime caseDate in model.DateList)
                    {
                        if (tempCaseCount?.Count > 0)
                        {
                            DashboardCaseCount temp = tempCaseCount.Find(c => c.Date.Date == caseDate.Date);
                            if (temp != null)
                            {
                                caseCount.Add(temp);
                                continue;
                            }
                        }
                        caseCount.Add(new DashboardCaseCount() { Date = caseDate, CaseCount = 0 });
                    }

                    model.CaseCounts = caseCount;
                }

                if (orders?.Count > 0)
                {
                    //Add order count
                    var tempOrder = orders.GroupBy(o => new
                    {
                        o.OrderDate.Date,
                        o.OrderStatusId,
                    }).Select(gcs => new
                    {
                        Date = gcs.Key.Date,
                        StatusId = gcs.Key.OrderStatusId,
                        Counter = gcs.Count()
                    }).ToList();

                    List<DashboardOrderCount> orderCount = new List<DashboardOrderCount>();
                    foreach (DateTime date in model.DateList)
                    {
                        if (tempOrder?.Count > 0)
                        {
                            int tempPending = tempOrder.Where(c => c.Date.Date == date.Date && (c.StatusId == 1 || c.StatusId == 2)).Sum(d => d.Counter);
                            int tempAccepted = tempOrder.Where(c => c.Date.Date == date.Date && (c.StatusId == 3 || c.StatusId == 8 || c.StatusId == 9)).Sum(d => d.Counter);
                            int tempDelivered = tempOrder.Where(c => c.Date.Date == date.Date && (c.StatusId == 5 || c.StatusId == 6 || c.StatusId == 10 || c.StatusId == 11)).Sum(d=>d.Counter);
                            int tempRejected = tempOrder.Where(c => c.Date.Date == date.Date && (c.StatusId == 7)).Sum(d => d.Counter);

                            orderCount.Add(new DashboardOrderCount()
                            {
                                Date = date,
                                PendingCount = tempPending,
                                AcceptedCount = tempAccepted,
                                DeliveredCount = tempDelivered,
                                RejectedCount = tempRejected
                            });
                        }
                        else
                        {
                            orderCount.Add(new DashboardOrderCount()
                            {
                                Date = date,
                                PendingCount = 0,
                                AcceptedCount = 0,
                                DeliveredCount = 0,
                                RejectedCount = 0
                            });
                        }
                    }
                    model.OrderCounts = orderCount;

                    //Order Product
                    List<DashboardOrder> orderProducts = new List<DashboardOrder>();
                    foreach (TblOrder order in orders)
                    {
                        if (order.Case != null && order.Case.CaseProducts?.Count > 0)
                        {
                            DashboardOrder orderProduct = new DashboardOrder();
                            orderProduct.OrderId = order.Id;
                            orderProduct.OrderStatusId = order.OrderStatusId;
                            List<DashboardOrderProduct> products = new List<DashboardOrderProduct>();
                            foreach (TblCaseProduct productData in order.Case.CaseProducts)
                            {
                                DashboardOrderProduct product = new DashboardOrderProduct();
                                product.ProductTypeId = productData.ProductTypeId;
                                
                                product.ProductId = productData.ProductId;
                                product.ProductName = productData.Product?.Name;
                                product.Qty = productData.Qty;
                                ProductGroupModel group = FindProductGroupFromProductId(productGroupModels,productData.ProductId);
                                if(group != null)
                                {
                                    product.ProductGroupId = group.Id;
                                    product.ProductGroupName = group.Name;
                                }

                                products.Add(product);
                            }
                            orderProduct.Products = products;

                            orderProducts.Add(orderProduct);
                        }
                    }
                    model.OrderProduct = orderProducts;
                }
            }

            return model;
        }

        private ProductGroupModel FindProductGroupFromProductId(List<ProductGroupModel> productGroups,int productId)
        {
            if(productGroups?.Count > 0)
            {
                foreach (ProductGroupModel group in productGroups)
                {
                    if(group.ProductItems != null && group.ProductItems.Any(p => p.Id == productId))
                    {
                        return new ProductGroupModel() { Id = group.Id, Name = group.Name };
                    }
                }
            }

            return null;
        }

        private async Task<List<DisplayOrder>> FillNameWithERP(List<DisplayOrder> displayOrders)
        {

            if (displayOrders?.Count > 0)
            {
                List<int> dentistIds = new List<int>();
                List<int> clinicIds = new List<int>();

                List<ERP.Models.DoctorModel> doctors = null;
                List<ERP.Models.ContactModel> clinics = null;

                dentistIds = displayOrders.Select(s => s.DentistId).Distinct().ToList();
                clinicIds = displayOrders.Select(s => s.ClinicId).Distinct().ToList();

                if (dentistIds?.Count > 0)
                    doctors = await _netforceService.GetDoctorByIdsAsync(dentistIds);
                if (clinicIds?.Count > 0)
                    clinics = await _netforceService.GetContactByIdsAsync(clinicIds);

                foreach (DisplayOrder displayOrder in displayOrders)
                {
                    displayOrder.ClinicName = clinics.Find(d => d.Id == displayOrder.ClinicId)?.Name;
                    displayOrder.DentistName = doctors.Find(d => d.Id == displayOrder.DentistId)?.Name;
                }
            }

            return displayOrders;
        }

        private List<DisplayOrder> getOrdersWithFilter(
            List<DisplayOrder> orders
            , int searchType
            , string searchStr
            , SearchRoleEnum role)
        {
            List<DisplayOrder> tempOrders = new List<DisplayOrder>(orders);

            if(String.IsNullOrEmpty(searchStr))
            {
                return orders;
            }

            searchStr = searchStr.ToLower();

            if (searchType != (int)SearchRoleEnum.all)
            {
                // TODO : implement filter with 'searchStr' case search specific role 
                if (searchType == (int)SearchRoleEnum.clinic)
                {
                    tempOrders = orders.Where(order =>order.ClinicName.ToLower().Contains(searchStr)).ToList();
                }

                if (searchType == (int)SearchRoleEnum.doctor)
                {
                    tempOrders = orders.Where(order => order.DentistName.ToLower().Contains(searchStr)).ToList();
                }


                if (searchType == (int)SearchRoleEnum.orderRef)
                {
                    tempOrders = orders.Where(order => order.OrderRef.ToLower().Contains(searchStr)).ToList();
                }


                if (searchType == (int)SearchRoleEnum.patientName)
                {
                    tempOrders = orders.Where(order => order.PatientName.ToLower().Contains(searchStr)).ToList();
                }

            }
            else
            {
                // search all 
                if (role == SearchRoleEnum.doctor)
                {
                    tempOrders = orders.Where(order =>
                        order.PatientName.ToLower().Contains(searchStr)
                        || order.ClinicName.ToLower().Contains(searchStr)
                        || order.OrderRef.ToLower().Contains(searchStr)
                    ).ToList();
                }
                else if((role == SearchRoleEnum.clinic))
                {
                    tempOrders = orders.Where(order =>
                        order.PatientName.ToLower().Contains(searchStr)
                        || order.DentistName.ToLower().Contains(searchStr)
                        || order.OrderRef.ToLower().Contains(searchStr)
                    ).ToList();
                }else
                {
                    tempOrders = orders.Where(order =>
                        order.PatientName.ToLower().Contains(searchStr)
                        || order.DentistName.ToLower().Contains(searchStr)
                        || order.ClinicName.ToLower().Contains(searchStr)
                        || order.OrderRef.ToLower().Contains(searchStr)
                    ).ToList();
                }

            }

            return tempOrders;
        }

        private List<DisplayOrder> getOrdersWithFilterByProductType(List<DisplayOrder> orders, int productTypeId)
        {
            if (productTypeId == 0)
            {
                return orders;
            }

            List<DisplayOrder> tempOrders = new List<DisplayOrder>(orders);

            tempOrders = orders.Where(order => order.ProductTypeIds.Contains(productTypeId)).ToList();
                
            return tempOrders;
        }

        private List<DisplayOrder> getOrdersWithFilterByProductTypes(List<DisplayOrder> orders, List<int> productTypeIds)
        {
            if (productTypeIds?.Count == 0)
            {
                return orders;
            }

            List<DisplayOrder> tempOrders = new List<DisplayOrder>(orders);

            tempOrders = orders.Where(order => order.ProductTypeIds.Any(item => productTypeIds.Contains(item))).ToList();

            return tempOrders;
        }

        private List<DisplayOrder> sortOrderByType(string sortOrder, List<DisplayOrder> orders)
        {
            switch (sortOrder)
            {
                case "orderRef":
                    orders = orders.OrderBy(order => order.OrderRef).ToList();
                    break;
                case "orderRef_desc":
                    orders = orders.OrderByDescending(order => order.OrderRef).ToList();
                    break;
                case "patient":
                    orders = orders.OrderBy(order => order.PatientName).ToList();
                    break;
                case "patient_Desc":
                    orders = orders.OrderByDescending(order => order.PatientName).ToList();
                    break;
                case "case":
                    orders = orders.OrderBy(order => order.CaseType).ToList();
                    break;
                case "case_Desc":
                    orders = orders.OrderByDescending(order => order.CaseType).ToList();
                    break;
                case "orderDate":
                    orders = orders.OrderBy(order => order.OrderDate).ToList();
                    break;
                case "orderDate_Desc":
                    orders = orders.OrderByDescending(order => order.OrderDate).ToList();
                    break;
                case "requestDate":
                    orders = orders.OrderBy(order => order.RequestDeliveryDate).ToList();
                    break;
                case "requestDate_Desc":
                    orders = orders.OrderByDescending(order => order.RequestDeliveryDate).ToList();
                    break;
                case "product":
                    orders = orders.OrderBy(order => order.ProductType).ToList();
                    break;
                case "product_Desc":
                    orders = orders.OrderByDescending(order => order.ProductType).ToList();
                    break;
                case "clinic":
                    orders = orders.OrderBy(order => order.ClinicName).ToList();
                    break;
                case "clinic_Desc":
                    orders = orders.OrderByDescending(order => order.ClinicName).ToList();
                    break;
                case "dentist":
                    orders = orders.OrderBy(order => order.DentistName).ToList();
                    break;
                case "dentist_Desc":
                    orders = orders.OrderByDescending(order => order.DentistName).ToList();
                    break;
                default:
                    orders = orders.OrderByDescending(order => order.OrderDate).ToList();
                    break;
            }

            return orders;
        }

        public async Task<string> UpdateEstimatedDate(UpdateEstimatedDateRequest model)
        {
            if (model == null)
                return "Update Expected Delivery Date error, Bad request model";

            OrderDetailModel orderDetail = await _orderRepo.GetOrderDetail(model.OrderId);
            DateTime? oldEstimatedDate = orderDetail.ExpectedDate;
            DisplayCaseModel caseModel = await _caseService.GetCaseByCaseId(orderDetail.CaseId);

            TblOrder order = await _orderRepo.UpdateEstimatedDate(model.OrderId, model.EstimatedDate);
            if (order == null)
                return "Update Expected Delivery Date error";
       
            // send notification

            ReceiveNotificationModel notificationModel = new ReceiveNotificationModel();
            notificationModel.Message = "Order " + order.ReferenceNumber;
            notificationModel.Message += "\nคนไข้คุณ " + caseModel.PatientName;
            notificationModel.Message += "\nกำหนดผลิตเสร็จวันที่ " + model.EstimatedDate.ToString("dd-MM-yyyy");
            if(!string.IsNullOrEmpty(model.NotificationText))
                notificationModel.Message += "\n : " + model.NotificationText;

            notificationModel.Title = "วันคาดว่าส่งสินค้าเปลี่ยนแปลง";
            notificationModel.userId = order.Case.UserId;

            int createNotiResult = await _notificationService.CreateNotificationAsync(order.Case.UserId, notificationModel);
                
            // send notification (email,notification)
            if (caseModel != null)
            {
                MarketingMemberModel clinicMemberModel = await _marketingService.GetMemberByCustomerIdAndType(caseModel.ClinicId, "clinic");
                MarketingMemberModel doctorMemberModel = await _marketingService.GetMemberByCustomerIdAndType(caseModel.DentistId, "doctor");
                SendNotificationServices(order, model, caseModel, clinicMemberModel, doctorMemberModel, oldEstimatedDate);
            }

            if(createNotiResult == 0)
                return "Send notification error.";
               
            return string.Empty;        
        }

        private async void SendNotificationServices(TblOrder order
            , UpdateEstimatedDateRequest model
            , DisplayCaseModel caseModel
            , MarketingMemberModel clinicMemberModel
            , MarketingMemberModel doctorMemberModel
            , DateTime? oldEstimatedDate)
            {
            // send email if estimation order is delay.

            if (caseModel != null)
            {
                bool isOrderDelay = caseModel.RequestDate < model.EstimatedDate;
                bool hasRequestDate = caseModel.RequestDate != null;

                _logger.LogInformation($"Call SendNotificationServices");
                // only when product delay we send email/sms
                if (isOrderDelay)
                {
                    if (clinicMemberModel != null && clinicMemberModel.EmailNoti?.Length > 0)
                    {
                        EmailModel emailModel = new EmailModel();

                        emailModel.MessageBody = FormEmail(clinicMemberModel.Name
                            , order.ReferenceNumber
                            , model.EstimatedDate
                            , hasRequestDate
                            , caseModel
                            , isOrderDelay
                            , oldEstimatedDate);

                        emailModel.MessageSubject = "[Hexa Online Ordering] สถานะ order เปลี่ยนแแปลง";
                        emailModel.TargetEmail = clinicMemberModel.EmailNoti;
                        _logger.LogInformation($"Call SendEmail to clinic Orderid {model.OrderId}");
                         _emailService.SendEmail(emailModel);
                    }

                    if (doctorMemberModel != null &&  doctorMemberModel.EmailNoti?.Length > 0)
                    {
                        EmailModel emailModel = new EmailModel();

                        emailModel.MessageBody = FormEmail(doctorMemberModel.Name
                            , order.ReferenceNumber
                            , model.EstimatedDate
                            , hasRequestDate
                            , caseModel
                            , isOrderDelay
                            , oldEstimatedDate);

                        emailModel.MessageSubject = "[Hexa Online Ordering] สถานะ order เปลี่ยนแแปลง";
                        emailModel.TargetEmail = doctorMemberModel.EmailNoti;

                        _logger.LogInformation($"Call SendEmail to doctor Orderid {model.OrderId}");
                        _emailService.SendEmail(emailModel);
                    }

                    if (clinicMemberModel != null && clinicMemberModel.PhoneNoti?.Length > 0)
                    {
                        await _smsService.SendSMS(clinicMemberModel.PhoneNoti, order.Id);
                    }

                    if (doctorMemberModel != null && doctorMemberModel.PhoneNoti?.Length > 0)
                    {
                        await _smsService.SendSMS(doctorMemberModel.PhoneNoti, order.Id);
                    }
                }

            }
        }

        private  string FormEmail(string name, string orderRef, DateTime estimatedDate, bool hasRequestDate, DisplayCaseModel caseModel, bool isOrderDelay, DateTime? oldEstimatedDate)
        {

            string body = $"<p>เรียน {name} </p></br>";
            body += topicEmailBody(oldEstimatedDate);

            body += $"<p>&emsp; ชื่อคนไข้  {caseModel.PatientName} </p>" +
                    $"<p>&emsp; ชื่อทันตแพทย์ {caseModel.DentistName} </p>" +
                    $"<p>&emsp; ผลิตภัณฑ์ {string.Join(", ", caseModel.CaseOrderLists.Select(order => order.SelectProduct.Name))}</p>";

            body += estimateEmailBody(estimatedDate, oldEstimatedDate);

            body += $"<p>บริษัทฯกราบขออภัยในความไม่สะดวกมา ณ ที่นี้</p>" +
                    $"<p>บริษัท เอ็กซา ซีแลม  จำกัด</p>";

            return body;
        }
        private string topicEmailBody(DateTime? oldEstimatedDate)
        {
            if (oldEstimatedDate.HasValue)
            {
                return $"<p>&emsp; แจ้งเปลี่ยนแปลงวันเสร็จสิ้นการผลิต</p>";
            }
            return $"<p>&emsp; แจ้งกำหนดวันเสร็จสิ้นการผลิต</p>";

        }

        private string estimateEmailBody(DateTime estimatedDate, DateTime? oldEstimatedDate)
        {
            if (oldEstimatedDate.HasValue)
            {
                return $"<p>&emsp; จากวันที่ {oldEstimatedDate.Value.ToString("dd-MM-yyyy")} เปลี่ยนเป็นวันที่ {estimatedDate.ToString("dd-MM-yyyy")}  </p></br>";
            }
              return $"<p>&emsp; เป็นวันที่ {estimatedDate.ToString("dd-MM-yyyy")}  </p></br>";
            
        }
        #endregion
    }

}
