using HexaOnlineOrdering.Repositories.DataModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HexaOnlineOrdering.Repositories.Interfaces;
using HexaOnlineOrdering.Models;
using Microsoft.EntityFrameworkCore;
using HexaOnlineOrdering.Models.Orders;

namespace HexaOnlineOrdering.Repositories
{
    public class OrderOverviewRepository : EntityBaseRepository<TblOrder, HexaDBContext>, IOrderOverviewRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;
        public OrderOverviewRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> DeleteOrderById(int orderId)
        {
            if(orderId < 0)
            {
                return -1;
            }

            TblOrder orders = await _dbContext.Orders.Where(o => !o.Disabled && o.Id == orderId).SingleOrDefaultAsync();
            if (orders == null)
            {
                return -1;
            }

            _dbContext.Remove(orders);
            _dbContext.SaveChanges();
            return orderId;
        }
        public async Task<List<DisplayOrder>> GetClinicOrders(int clinicId
            , DateTime from
            , DateTime to
            , int status
            , int searchType
            , string searchStr
            , int page
            , int dentistId)
        {

            List<TblOrder> orders = new List<TblOrder>();

            if (status == (int)OrderStatusEnum.waitingOrDraft || status == (int)OrderStatusEnum.draft || status == (int)OrderStatusEnum.waitingOrder)
            {
                orders = await _dbContext.Orders
                    .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                    .Include(o => o.Case).ThenInclude(c => c.CaseType)
                    .Include(o => o.OrderStatus)
                    .Where(o => !o.Disabled && o.Case != null && o.Case.OrganizationId.HasValue && o.Case.OrganizationId.Value == clinicId
                    && o.OrderDate.Date >= from.Date && o.OrderDate.Date <= to.Date
                    && (clinicId == 0 || o.Case.OrganizationId == clinicId) &&
                    (o.OrderStatus.Id == (int)OrderStatusEnum.waitingOrDraft
                    || o.OrderStatus.Id == (int)OrderStatusEnum.draft
                    || o.OrderStatus.Id == (int)OrderStatusEnum.waitingOrder)).ToListAsync();
            }
            else
            {
                orders =  await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                .Include(o => o.Case).ThenInclude(c => c.CaseType)
                .Include(o => o.OrderStatus)
                .Where(o => !o.Disabled && o.Case != null && o.Case.OrganizationId.HasValue && o.Case.OrganizationId.Value == clinicId
                && o.OrderDate.Date >= from.Date && o.OrderDate.Date <= to.Date && (status == 0 || o.OrderStatus.Id == status)
                && (dentistId == 0 || o.Case.DoctorId == dentistId)).ToListAsync();
            }

            if (orders == null)
            {
                return null;
            }


            List<DisplayOrder> displayOrders = new List<DisplayOrder>();

            foreach (TblOrder item in orders)
            {
                DisplayOrder displayOrder = CustomMapping.CustomMapTblToModel.MapDisplayOrders(item);

                List<string> productTypeList = GetProductInCase(item.Case);
                displayOrder.ProductType = productTypeList != null ? string.Join(',', productTypeList) : string.Empty;

                List<int> productTypeIdList = GetProductTypeIdListInCase(item.Case);
                displayOrder.ProductTypeIds = productTypeIdList;

                displayOrders.Add(displayOrder);

            }
            return displayOrders;
        }

        private bool isPermissionProductTypes(int productTypeId, List<int> productTypeIds)
        {
            if (productTypeIds?.Count == 0)
                return true;

            return productTypeIds.Contains(productTypeId);
        }

        public async Task<List<AdminReportModel>> GetOrdersReportFilterByDate(DateTime fromDate, DateTime toDate, int[] status, List<int> adminPermission)
        {
            List<TblOrder> orders = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                .Include(o => o.Case).ThenInclude(c => c.CaseType)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Product)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Materials).ThenInclude(m => m.Material)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Designs).ThenInclude(m => m.Design)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.AddOns).ThenInclude(m => m.AddOn)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.Method)
                .Include(o => o.OrderStatus)
                .Include(o => o.RejectNote)
                .Where(o => !o.Disabled && o.Case != null
                && o.OrderDate.Date >= fromDate.Date && o.OrderDate.Date <= toDate.Date
                && (status.Contains(0) ? true : status.Contains(o.OrderStatusId))).ToListAsync();

            if(orders != null)
            {
                List<AdminReportModel> models = new List<AdminReportModel>();
                int keyCounter = 0;
                foreach (TblOrder order in orders)
                {
                    if(order.Case?.CaseProducts?.Count > 0)
                    {                     
                        Dictionary<int, List<SelectedProduct>> productInTypeDic = new Dictionary<int, List<SelectedProduct>>();
                        foreach (TblCaseProduct caseProduct in order.Case.CaseProducts)
                        {
                            if(!isPermissionProductTypes(caseProduct.ProductTypeId, adminPermission))
                            {
                                continue;
                            }
                            SelectedProduct product = new SelectedProduct();
                            if (caseProduct.TeethNumber.HasValue)
                                product.No = caseProduct.TeethNumber.Value.ToString();
                            else if (caseProduct.Section.HasValue)
                            {
                                if (caseProduct.Section.Value == DataModels.CaseSectionEnum.Upper)
                                    product.No = "Maxilla";
                                else if (caseProduct.Section.Value == DataModels.CaseSectionEnum.Lower)
                                    product.No = "Mandible";
                            }
                            product.Option = caseProduct.Option;
                            product.ProductName = caseProduct.Product?.Name;
                            product.ProductTypeId = caseProduct.ProductTypeId;
                            product.ProductType = caseProduct.ProductType?.Name;
                            product.Method = caseProduct.Method?.Name;
                            product.Shade = caseProduct.Shade;
                            product.ShadeSystem = caseProduct.ShadeSystem;
                            product.Age = order.Case.Age;
                            product.Gender = order.Case.Gender;

                            if (caseProduct.Materials?.Count > 0)
                            {
                                product.MeterialName = caseProduct.Materials.Select(s => s.Material?.Name).FirstOrDefault();
                            }

                            if (caseProduct.Designs?.Count > 0)
                            {
                                product.DesignName = caseProduct.Designs.Select(s => s.Design?.Name).FirstOrDefault();
                            }

                            if(caseProduct.AddOns?.Count > 0)
                            {
                                List<SelectedAddOn> addOns = new List<SelectedAddOn>();
                                foreach (TblCaseProductAddOn addOnData in caseProduct.AddOns)
                                {
                                    SelectedAddOn addOn = new SelectedAddOn();
                                    addOn.Input = addOnData.InputAddOn;
                                    addOn.AddOnName = addOnData.AddOn?.DisplayName;
                                    addOns.Add(addOn);
                                }
                                product.SelectedAddOns = addOns;
                            }      
                            
                            if(productInTypeDic.ContainsKey(caseProduct.ProductTypeId))
                            {
                                if (productInTypeDic[caseProduct.ProductTypeId] == null)
                                    productInTypeDic[caseProduct.ProductTypeId] = new List<SelectedProduct>();

                                productInTypeDic[caseProduct.ProductTypeId].Add(product);
                            }
                            else
                            {
                                productInTypeDic.Add(caseProduct.ProductTypeId, new List<SelectedProduct>() { product });
                            }
                        }

                        if(productInTypeDic.Count > 0)
                        {
                            // record by product type
                            foreach (KeyValuePair<int, List<SelectedProduct>> products in productInTypeDic)
                            {
                                if (products.Value?.Count > 0)
                                {
                                    keyCounter++;
                                    AdminReportModel model = new AdminReportModel();
                                    model.RowKey = string.Format("{0}_{1}", order.ReferenceNumber, keyCounter);
                                    model.OrderRef = order.ReferenceNumber;
                                    model.StatusId = order.OrderStatusId;
                                    model.OrderDate = order.OrderDate;
                                    if (order.OrderStatus != null)
                                        model.Status = order.OrderStatus.Name;

                                    model.PatientName = order.Case.PatientName;
                                    model.DentistId = order.Case.DoctorId ?? 0;
                                    model.ClinicId = order.Case.OrganizationId ?? 0;
                                    model.CaseType = order.Case.CaseType?.Name;

                                    model.ProductTypeId = products.Value[0].ProductTypeId;
                                    model.ProductType = products.Value[0].ProductType;
                                    model.Method = products.Value[0].Method;

                                    model.SelectedProducts = products.Value;
                                    model.RejectNote = BindingRejectNote(order.RejectNote);

                                    models.Add(model);
                                }
                            }
                        }
                        
                    }                 
                }
                return models;
            }
            return null;
        }
        public async Task<List<DisplayOrder>>  GetOrdersFilterByDateAndStatus(DateTime fromDate, DateTime toDate, int[] status)
        {
            List<TblOrder> orders = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                .Include(o => o.Case).ThenInclude(c => c.CaseType)
                .Include(o => o.OrderStatus)
                .Where(o => !o.Disabled && o.Case != null
                && o.OrderDate.Date >= fromDate.Date && o.OrderDate.Date <= toDate.Date
                && (status.Contains(0) ? true : status.Contains(o.OrderStatusId))).OrderByDescending(o => o.OrderDate).ToListAsync();

            if (orders == null)
            {
                return null;
            }

            List<DisplayOrder> displayOrders = new List<DisplayOrder>();

            foreach (TblOrder item in orders)
            {
                DisplayOrder displayOrder = CustomMapping.CustomMapTblToModel.MapDisplayOrders(item);

                List<string> productTypeList = GetProductInCase(item.Case);
                displayOrder.ProductType = productTypeList != null ? string.Join(',', productTypeList) : string.Empty;

                List<int> productTypeIdList = GetProductTypeIdListInCase(item.Case);
                displayOrder.ProductTypeIds = productTypeIdList;

                displayOrders.Add(displayOrder);

            }

            return displayOrders;
        }

        public async Task<int> GetCurrentReferenceNumber(DateTime currentDate)
        {
            int result = 0;
            TblOrder order = await _dbContext.Orders.Where(o => o.OrderDate.Date == currentDate.Date).OrderByDescending(o => o.ReferenceNumber).FirstOrDefaultAsync();
            if(order != null)
            {
                string[] numberStrings = order.ReferenceNumber.Split(currentDate.ToString("yyyyMMdd"));
                if(numberStrings.Length > 0)
                {
                    string numberString = numberStrings[numberStrings.Length - 1];                   
                    if(!int.TryParse(numberString,out result))
                        result = 0;
                }
            }
            return result;
        }

        public async Task<List<DisplayOrder>> GetDentistOrders(int dentistId
            , DateTime from
            , DateTime to
            , int status
            , int searchType
            , string searchStr
            , int page
            , int clinicId)
        {
            List<TblOrder> orders = new List<TblOrder>();

            if (status == (int)OrderStatusEnum.waitingOrDraft || status == (int)OrderStatusEnum.draft || status == (int)OrderStatusEnum.waitingOrder)
            {
                orders = await _dbContext.Orders
                    .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                    .Include(o => o.Case).ThenInclude(c => c.CaseType)
                    .Include(o => o.OrderStatus)
                    .Where(o => !o.Disabled && o.Case != null && o.Case.DoctorId.HasValue && o.Case.DoctorId.Value == dentistId
                    && o.OrderDate.Date >= from.Date && o.OrderDate.Date <= to.Date && (clinicId == 0 || o.Case.OrganizationId == clinicId)
                    && (o.OrderStatus.Id == (int)OrderStatusEnum.waitingOrDraft
                    || o.OrderStatus.Id == (int)OrderStatusEnum.draft 
                    || o.OrderStatus.Id == (int)OrderStatusEnum.waitingOrder)).ToListAsync();
            }
            else {

                orders = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                .Include(o => o.Case).ThenInclude(c => c.CaseType)
                .Include(o => o.OrderStatus)
                .Where(o => !o.Disabled && o.Case != null && o.Case.DoctorId.HasValue && o.Case.DoctorId.Value == dentistId
                && o.OrderDate.Date >= from.Date && o.OrderDate.Date <= to.Date 
                && (status == 0 || o.OrderStatus.Id == status)
                && (clinicId == 0 || o.Case.OrganizationId == clinicId)).ToListAsync();
            }

            if(orders == null)
            {
                return null;
            }

            List<DisplayOrder> displayOrders = new List<DisplayOrder>();

            foreach (TblOrder item in orders)
                {
                    DisplayOrder displayOrder = CustomMapping.CustomMapTblToModel.MapDisplayOrders(item);
                    List<string> productTypeList = GetProductInCase(item.Case);
                    displayOrder.ProductType = productTypeList != null ? string.Join(',', productTypeList) : string.Empty;
                    List<int> productTypeIdList = GetProductTypeIdListInCase(item.Case);
                    displayOrder.ProductTypeIds = productTypeIdList;

                displayOrders.Add(displayOrder);

                }
            return displayOrders;
        }

        public async Task<List<DisplayOrder>> GetDentistOrdersFilterByDateAndStatus(DateTime fromDate, DateTime toDate, List<int> status, int dentistId, int clinicId)
        {
            List<TblOrder> orders = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                .Include(o => o.Case).ThenInclude(c => c.CaseType)
                .Include(o => o.OrderStatus)
                .Where(o => !o.Disabled && o.Case != null && o.Case.DoctorId.HasValue && o.Case.DoctorId.Value == dentistId
                && o.OrderDate.Date >= fromDate.Date && o.OrderDate.Date <= toDate.Date && (status.Contains(0) ? true : status.Contains(o.OrderStatusId))
                && (clinicId == 0 || o.Case.OrganizationId == clinicId)).ToListAsync();

            if (orders == null)
            {
                return null;
            }

            List<DisplayOrder> displayOrders = new List<DisplayOrder>();

            foreach (TblOrder item in orders)
            {
                DisplayOrder displayOrder = CustomMapping.CustomMapTblToModel.MapDisplayOrders(item);

                List<string> productTypeList = GetProductInCase(item.Case);
                displayOrder.ProductType = productTypeList != null ? string.Join(',', productTypeList) : string.Empty;

                List<int> productTypeIdList = GetProductTypeIdListInCase(item.Case);
                displayOrder.ProductTypeIds = productTypeIdList;

                displayOrders.Add(displayOrder);

            }

            return displayOrders;
        }
        public async Task<List<DisplayOrder>> GetClinicOrdersFilterByDateAndStatus(DateTime fromDate, DateTime toDate, List<int> status, int clinicId, int dentistId)
        {
            List<TblOrder> orders = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
                .Include(o => o.Case).ThenInclude(c => c.CaseType)
                .Include(o => o.OrderStatus)
                .Where(o => !o.Disabled && o.Case != null && o.Case.OrganizationId.HasValue && o.Case.OrganizationId.Value == clinicId
                && o.OrderDate.Date >= fromDate.Date && o.OrderDate.Date <= toDate.Date && (status.Contains(0) ? true : status.Contains(o.OrderStatusId))
                && (dentistId == 0 || o.Case.DoctorId == dentistId)).ToListAsync();
       
            if (orders == null)
            {
                return null;
            }

            List<DisplayOrder> displayOrders = new List<DisplayOrder>();

            foreach (TblOrder item in orders)
            {
                DisplayOrder displayOrder = CustomMapping.CustomMapTblToModel.MapDisplayOrders(item);

                List<string> productTypeList = GetProductInCase(item.Case);
                displayOrder.ProductType = productTypeList != null ? string.Join(',', productTypeList) : string.Empty;
                List<int> productTypeIdList = GetProductTypeIdListInCase(item.Case);
                displayOrder.ProductTypeIds = productTypeIdList;

                displayOrders.Add(displayOrder);

            }

            return displayOrders;
        }

        public async Task<List<CaseItemModel>> GetOrderSmallDetailList(int orderId)
        {
            List<CaseItemModel> caseOrderList = new List<CaseItemModel>();
            TblOrder order = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Product).ThenInclude(p => p.AddOns)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Materials).ThenInclude(pm => pm.Material)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Designs).ThenInclude(pm => pm.Design)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.AddOns).ThenInclude(pm => pm.AddOn)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.Method)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.ShadeSystemObject)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.ShadeObject)
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.ProductType).Where(o => o.Id == orderId).SingleOrDefaultAsync();

            if (order != null && order.Case != null)
            {
                DisplayCaseModel displayCase = CustomMapping.CustomMapTblToModel.MapDisplayCaseModel(order.Case);
                caseOrderList = displayCase.CaseOrderLists;
            }

            return caseOrderList;
        }

        public async Task<OrderDetailModel> GetOrderDetail(int orderId)
        {
            TblOrder order = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseAttachedFiles)
                .Include(o => o.RejectNote).ThenInclude(r=>r.RejectUser)
                .Include(o => o.OrderStatus)
                .Where(o => o.Id == orderId).SingleOrDefaultAsync();

            return BindingOrderDetail(order);
        }

        public async Task<OrderDetailModel> GetOrderDetail(string referenceNumber)
        {
            TblOrder order = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseAttachedFiles)
                .Include(o => o.RejectNote).ThenInclude(r => r.RejectUser)
                .Include(o => o.OrderStatus)
                .Where(o => o.ReferenceNumber == referenceNumber).SingleOrDefaultAsync();

            return BindingOrderDetail(order);
        }

        public async Task<OrderDetailModel> GetOrderDetailByCasedId(int caseId)
        {
            TblOrder order = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseAttachedFiles)
                .Include(o => o.OrderStatus)
                .Where(o => o.CaseId == caseId).SingleOrDefaultAsync();

            return BindingOrderDetail(order);
        }

        public async Task<OrderDetailModel> ShowNotificationByCasedId(int caseId)
        {
            TblOrder order = await _dbContext.Orders
                .Where(o => o.CaseId == caseId).SingleOrDefaultAsync();
            
            order.IsNotification = true;
            _dbContext.Update(order);
            await _dbContext.SaveChangesAsync();
            
            return BindingOrderDetail(order);
        }

        private OrderDetailModel BindingOrderDetail(TblOrder order)
        {

            if (order == null)
            {
                return null;
            }

            OrderDetailModel orderDetail = new OrderDetailModel();
            orderDetail.Id = order.Id;
            orderDetail.CaseId = order.CaseId;
            orderDetail.OrderRef = order.ReferenceNumber;
            orderDetail.CaseName = order.Case?.CaseName;
            orderDetail.PatientName = order.Case?.PatientName;
            orderDetail.OrderedDate = order.OrderDate;
            orderDetail.RequestedDate = order.Case?.RequestDate;
            orderDetail.PickupDate = order.Case?.PickupDate;
            orderDetail.ExpectedDate = order.EstimatedDate;
            orderDetail.Memo = order.Case?.Memo;
            orderDetail.PathAttachedFiles = GetAttachedPathsFile(order.Case);
            orderDetail.Status = order.OrderStatusId;
            orderDetail.IsNotification = order.IsNotification;
            orderDetail.Age = order.Case.Age;
            orderDetail.Gender = order.Case.Gender;
            orderDetail.ClinicId = (int)order.Case?.OrganizationId;
            orderDetail.DoctorId = (int)order.Case?.DoctorId;
            orderDetail.Aligners = order.Case?.Aligners;
            orderDetail.RejectNote = BindingRejectNote(order.RejectNote);
            orderDetail.UserId = order.Case?.UserId ?? 0;

            return orderDetail;
        }

        public async Task<int> CancelOrder(int orderId)
        {
            if (orderId < 0){ return -1; }

            TblOrder order = await _dbContext.Orders
                .Where(o => o.Id == orderId && (o.OrderStatusId == (int)OrderStatusEnum.draft || o.OrderStatusId == (int)OrderStatusEnum.waitingOrder))
                .SingleOrDefaultAsync();

            if (order == null){ return -1; }

            order.OrderStatusId = (int)OrderStatusEnum.canceled;
            _dbContext.Update(order);

            int result = await _dbContext.SaveChangesAsync();

            if(result <= 0){ return -1; }

            return orderId;
        }

        private RejectNoteModel BindingRejectNote(TblRejectNote rejectNote)
        {
            RejectNoteModel model = new RejectNoteModel();
            if (rejectNote != null )
            {

                model.Id = rejectNote.Id;
                model.Note = rejectNote.Note;
                model.IsAdmin = rejectNote.IsAdmin;
                model.RejectDate = rejectNote.RejectDate;
                model.OrderId = rejectNote.OrderId;
                model.RejectUserId = rejectNote.RejectUserId;

                if(rejectNote.RejectUser != null)
                {
                    model.RejectUser = _mapper.Map<TblUser, UserModel>(rejectNote.RejectUser);
                }

            }
            return model;
        }

        private List<DisplayAttachFile> GetAttachedPathsFile(TblCase caseData)
        {
            List<DisplayAttachFile> paths = new List<DisplayAttachFile>();
            if (caseData != null && caseData.CaseAttachedFiles?.Count > 0)
            {
                foreach (TblCaseAttachedFile caseAttached in caseData.CaseAttachedFiles)
                {
                    DisplayAttachFile file = new DisplayAttachFile();
                    file.Id = caseAttached.Id;
                    file.FileName = caseAttached.FileName;
                    file.FilePath = caseAttached.FilePath;
                    file.CaseId = caseAttached.CaseId;
                    file.FileTypeId = caseAttached.FileTypeId;
                    file.UploadDate = caseAttached.UploadedDate;
                    file.CasePresentationHistoryId = caseAttached.CasePresentationHistoryId;

                    paths.Add(file);
                }
            }
            return paths;
        }

        public async Task<int> GetCaseIdByOrderId(int orderId)
        {
            TblOrder tblorder = await _dbContext.Orders.Where(o => o.Id == orderId).SingleOrDefaultAsync();

            if (tblorder == null)
            {
                return -1;
            }

            return tblorder.CaseId;
        }
        private List<string> GetProductInCase(TblCase caseData)
        {
            List<string> productTypes = new List<string>();
            if (caseData != null && caseData.CaseProducts?.Count > 0)
            {
                foreach (TblCaseProduct caseProduct in caseData.CaseProducts)
                {
                    if (caseProduct.ProductType != null && !productTypes.Contains(caseProduct.ProductType.Name))
                        productTypes.Add(caseProduct.ProductType.Name);
                }
            }
            return productTypes;
        }

        private List<int> GetProductTypeIdListInCase(TblCase caseData)
        {
            List<int> productTypesId = new List<int>();
            if (caseData != null && caseData.CaseProducts?.Count > 0)
            {
                foreach (TblCaseProduct caseProduct in caseData.CaseProducts)
                {
                    if (!productTypesId.Contains(caseProduct.ProductTypeId))
                        productTypesId.Add(caseProduct.ProductTypeId);
                }
            }
            return productTypesId;
        }

        private List<string> GetMethodInCase(TblCase caseData)
        {
            List<string> methods = new List<string>();
            if (caseData != null && caseData.CaseProducts?.Count > 0)
            {
                foreach (TblCaseProduct caseProduct in caseData.CaseProducts)
                {
                    if (caseProduct.Method != null)
                    {
                        methods.Add(caseProduct.Method.Name);
                    }
                }
            }
            return methods;
        }

        public async Task<List<TblOrder>> GetClinicOrderForDashboard(int clinicId, DateTime startDate, DateTime endDate, int dentistId)
        {
            List<TblOrder> orderTable = await _dbContext.Orders
                .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Product)
             .Where(o => o.Case != null && o.Case.OrganizationId.HasValue && o.Case.OrganizationId.Value == clinicId 
             && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date
             && (dentistId == 0 || o.Case.DoctorId == dentistId)).ToListAsync();
            return orderTable;
        }

        public async Task<List<TblOrder>> GetDentistOrderForDashboard(int dentistId, DateTime startDate, DateTime endDate, int clinicId)
        {
            List<TblOrder> orderTable = await _dbContext.Orders
               .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Product)
            .Where(o => o.Case != null && o.Case.DoctorId.HasValue && o.Case.DoctorId.Value == dentistId 
            && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date
            && (clinicId == 0 || o.Case.OrganizationId == clinicId)).ToListAsync();
            return orderTable;
        }

        public async Task<List<TblOrder>> GetOrderForAdminDashboard(DateTime startDate, DateTime endDate)
        {
            List<TblOrder> orderTable = await _dbContext.Orders
               .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Product)
            .Where(o => o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date).ToListAsync();
            return orderTable;
        }

        public async Task<DateTime?> CalculateEstimatedDate(int orderId)
        {
            TblOrder orderTable = await _dbContext.Orders
               .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Product)
               .Where(o => o.Id == orderId).SingleOrDefaultAsync();

            int maxEstimateDay = 0;
            if (orderTable?.Case?.CaseProducts?.Count > 0)
            {
                foreach (TblCaseProduct  caseProduct in orderTable?.Case?.CaseProducts)
                {
                    if (caseProduct?.Product != null)
                    {
                        if (caseProduct?.Product.ExpectedProductDay > maxEstimateDay)
                            maxEstimateDay = caseProduct.Product.ExpectedProductDay;
                    }
                }
            }

            if(maxEstimateDay > 0)
                return DateTime.Now.AddDays(maxEstimateDay);

            return null;        

        }

        public async Task<TblOrder> UpdateEstimatedDate(int orderId, DateTime estimatedDate)
        {
            if (orderId < 0)
                return null;


            /// Remove condition on api
            //TblOrder order = await _dbContext.Orders.Include(o => o.Case).Include(o => o.OrderStatus).Where(o => o.Id == orderId 
            //&& (o.OrderStatus.Id == (int)OrderStatusEnum.waitingOrDraft
            //        || o.OrderStatus.Id == (int)OrderStatusEnum.draft
            //        || o.OrderStatus.Id == (int)OrderStatusEnum.waitingOrder
            //        || o.OrderStatus.Id == (int)OrderStatusEnum.ordered)).SingleOrDefaultAsync();

            TblOrder order = await _dbContext.Orders.Include(o => o.Case).Include(o => o.OrderStatus).Where(o => o.Id == orderId).SingleOrDefaultAsync();

            if(order != null)
            {
                order.EstimatedDate = estimatedDate.Date;
                _dbContext.Update(order);
                await _dbContext.SaveChangesAsync();
            }
            return order;
        }

        public async Task<List<DisplayOrder>> GetOrderDisplayByIds(List<int> orderIds)
        {
            List<TblOrder> orders = new List<TblOrder>();

            orders = await _dbContext.Orders
            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Product).ThenInclude(p => p.AddOns)
            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Materials).ThenInclude(pm => pm.Material)
            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.Designs).ThenInclude(pm => pm.Design)
            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(cp => cp.AddOns).ThenInclude(pm => pm.AddOn)
            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.Method)
            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.ShadeSystemObject)
            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(p => p.ShadeObject)

            .Include(o => o.Case).ThenInclude(c => c.CaseProducts).ThenInclude(c => c.ProductType)
            .Include(o => o.Case).ThenInclude(c => c.CaseType)
            .Include(o => o.OrderStatus)

            .Where(o => !o.Disabled && o.Case != null && orderIds.Contains(o.Id))
            .ToListAsync();

            if (orders == null)
            {
                return null;
            }

            List<DisplayOrder> displayOrders = new List<DisplayOrder>();

            foreach (TblOrder item in orders)
            {
                DisplayOrder displayOrder = CustomMapping.CustomMapTblToModel.MapDisplayOrders(item);

                List<string> productTypeList = GetProductInCase(item.Case);
                displayOrder.ProductType = productTypeList != null ? string.Join(',', productTypeList) : string.Empty;

                displayOrders.Add(displayOrder);

            }

            displayOrders = displayOrders.OrderBy(o => orderIds.IndexOf(o.OrderId)).ToList();

            return displayOrders;
        }
    }
}
