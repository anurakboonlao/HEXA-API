using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.EntityFrameworkCore;
using HexaOnlineOrdering.Api.Extensions;
using HexaOnlineOrdering.Models.Case;
using HexaOnlineOrdering.Models.Notification;

namespace HexaOnlineOrdering.Api.Services
{
    public class CaseService : ICaseService
    {
        private readonly ICaseRepository _caseRepo;
        private readonly ICaseAttachedFileRepository _caseAttachedFile;
        private readonly ICaseProductRepository _caseProduct;
        private readonly IAWS3service _awsService;
        private readonly INetforceService _netforceService;
        private readonly IOrderOverviewRepository _orderRepo;
        private readonly INotificationService _notificationService;

        public CaseService( INotificationService notificationService, IOrderOverviewRepository orderRepo, IAWS3service awsService, ICaseRepository caseRepo, ICaseAttachedFileRepository caseAttachedFile, ICaseProductRepository caseProduct, INetforceService netforceService)
        {
            _caseRepo = caseRepo ?? throw new ArgumentNullException(nameof(caseRepo));
            _caseAttachedFile = caseAttachedFile ?? throw new ArgumentNullException(nameof(caseAttachedFile));
            _caseProduct = caseProduct ?? throw new ArgumentNullException(nameof(caseProduct));
            _netforceService = netforceService ?? throw new ArgumentNullException(nameof(netforceService));
            _awsService = awsService ?? throw new ArgumentNullException(nameof(awsService));
            _orderRepo = orderRepo ?? throw new ArgumentNullException(nameof(orderRepo));
            _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
        }

        public async Task DeleteCaseById(int caseId)
        {
            TblCase caseTable = await _caseRepo.GetCaseForUpdate(caseId);

            if(caseTable != null)
            {
                _caseRepo.Delete(caseTable);
                await _caseRepo.CommitAsync();
            }
        }

        public async Task<CaseModel> FindCaseHasOrderByCaseId(int caseId)
        {
            return await _caseRepo.GetCaseHasOrderByCaseId(caseId);

        }

        public async Task<DisplayCaseModel> GetCaseByCaseId(int caseId)
        {
            DisplayCaseModel caseModel = await _caseRepo.GetCaseByCaseId(caseId);

            if(caseModel == null)
            {
                return null;
            }

            List<DisplayCaseModel> caseModels = await FillNameWithERP(new List<DisplayCaseModel>() { caseModel });


            if (caseModels?.Count > 0)
            { 
                if(caseModel.CaseOrderLists?.Count > 0)
                {
                    // connect logo path 
                    foreach (CaseItemModel item in caseModel.CaseOrderLists)
                    {
                        if (item.SelectProduct != null && item.SelectProduct.Materials?.Count > 0)
                        {
                            foreach (MaterialModel material in item.SelectProduct.Materials)
                            {
                                material.LogoPath = _awsService.GenerateAwsRegularFileUrl(material.LogoPath);
                            }
                        }
                        if (item.SelectProduct != null && item.SelectProduct.Designs?.Count > 0)
                        {
                            foreach (DesignModel design in item.SelectProduct.Designs)
                            {
                                design.LogoPath = _awsService.GenerateAwsRegularFileUrl(design.LogoPath);
                            }
                        }
                        if (item.SelectProduct != null && item.SelectProduct.AddOnGroups?.Count > 0)
                        {
                            foreach (GroupAddOnModel addOnGroup in item.SelectProduct.AddOnGroups)
                            {
                                foreach (AddOnModel addOn in addOnGroup.AddOns)
                                {
                                    addOn.LogoPath = _awsService.GenerateAwsRegularFileUrl(addOn.LogoPath);
                                }

                            }
                        }
                    }
                }
                return caseModels[0];
            }
            else
            {
                return null;
            }

        }

        public async Task<CaseManageModel> GetCaseListByClinicId(int clinicId, DateTime fromDate, DateTime endTime, int dentistId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId)
        {
            CaseManageModel caseModel = await _caseRepo.GetCaseListByClinicId(clinicId, fromDate, endTime, dentistId, statusId, page, pageSize, sortField, sortOrder, filterField, filterText, caseTypeId, productTypeId);           
            if(caseModel?.CaseList?.Count > 0)
                caseModel.CaseList = await FillNameWithERP(caseModel.CaseList);
            return caseModel;
        }

        public async Task<CaseManageModel> GetCaseListByDentistId(int dentistId, DateTime fromDate, DateTime endTime, int clinicId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId)
        {
            CaseManageModel caseModel = await _caseRepo.GetCaseListByDentistId(dentistId, fromDate, endTime, clinicId, statusId, page, pageSize, sortField, sortOrder, filterField, filterText, caseTypeId, productTypeId);
            if (caseModel?.CaseList?.Count > 0)
                caseModel.CaseList = await FillNameWithERP(caseModel.CaseList);
            return caseModel;
        }

        public async Task<CaseModel> SaveCase(DisplayCaseModel caseData)
        {
            if (caseData?.CaseId == 0)
            {
                //create case
                return await _caseRepo.AddNewCase(caseData);
            }
            return null;
        }

        public async Task<int> SaveCase(DraftCaseModel caseData)
        {
            // return case Id
             return await _caseRepo.AddDraftCase(caseData);
        }

        public async Task<bool> SaveRequestDate(int caseId, DateTime? requestDate)
        {
            TblCase updateCase = _caseRepo.Get(c => c.Id == caseId);
            updateCase.RequestDate = requestDate;
            _caseRepo.Update(updateCase);
            int numberOfrow = await _caseRepo.CommitAsync();
            return numberOfrow > 0;
        }

        public async Task<CaseModel> UpdateCase(DisplayCaseModel caseData)
        {
            if (caseData?.CaseId > 0)
            {
                TblCase caseTable = await _caseRepo.GetCaseForUpdate(caseData.CaseId);

                if (caseTable != null)
                {
                    caseTable.CaseName = caseData.CaseName;
                    caseTable.PatientName = caseData.PatientName;
                    caseTable.LastUpdate = DateTime.Now;
                    caseTable.Memo = caseData.Memo;
                    caseTable.RequestDate = caseData.RequestDate;
                    caseTable.PickupDate = caseData.PickupDate;

                    if(caseData.Age > 0)
                        caseTable.Age = caseData.Age;
                    
                    if(caseData.Gender != null)
                        caseTable.Gender = caseData.Gender;
                    
                    
                    List<TblCaseProduct> newCaseProductList = new List<TblCaseProduct>();
                    if (caseData.CaseOrderLists?.Count > 0)
                    {                       
                        foreach (CaseItemModel productItem in caseData.CaseOrderLists)
                        {
                            if (productItem.SelectProduct != null)
                            {
                                TblCaseProduct caseProduct = Repositories.CustomMapping.CustomMapTblToModel.MapTblCaseProduct(productItem);
                                if (caseProduct != null)
                                    newCaseProductList.Add(caseProduct);
                            }
                        }                      
                    }

                    if (caseTable.CaseProducts?.Count > 0)
                    {
                        List<TblCaseProduct> removeCaseProduct = caseTable.CaseProducts.ToList();
                        _caseProduct.DeleteRange(removeCaseProduct);
                    }

                    if (newCaseProductList?.Count > 0)
                        caseTable.CaseProducts = newCaseProductList;

                    _caseRepo.Update(caseTable);
                    int result = await _caseRepo.CommitAsync();
                    if(result > 0)
                        return caseTable.MapTo<CaseModel>();
                }
            }
            return null;
        }

        public async Task<CaseModel> UpdateCaseMemoIcharm(int caseId, string memo)
        {
            TblCase caseTable = await _caseRepo.GetCaseForUpdate(caseId);
            if (caseTable != null)
            {
                caseTable.Memo = memo;
                _caseRepo.Update(caseTable);
                int result = await _caseRepo.CommitAsync();
                if (result > 0)
                {
                    await _orderRepo.ShowNotificationByCasedId(caseId);
                    return caseTable.MapTo<CaseModel>();
                }
            }
            return null;
        }

        public async Task<CaseModel> UpdateCaseAlignersIcharm(int caseId, string aligners)
        {
            TblCase caseTable = await _caseRepo.GetCaseForUpdate(caseId);

            if (caseTable != null)
            {
                caseTable.Aligners = aligners;
                _caseRepo.Update(caseTable);
                int result = await _caseRepo.CommitAsync();
                if (result > 0)
                    return caseTable.MapTo<CaseModel>();
            }
            return null;
        }

        public async Task<CaseProductModel> UpdateCaseProductIcharm(int caseId, int productId, string notificationText)
        {
            CaseProductModel caseProductUpdate = await _caseProduct.UpdateProductByCaseId(caseId, productId);
            
            if (caseProductUpdate == null)
            {
                return null;
            }

            TblCaseProduct caseProduct = await _caseProduct.GetCaseProductByCaseId(caseId);
            DisplayCaseModel caseModel = await GetCaseByCaseId(caseId);
            OrderDetailModel orderDetail = await _orderRepo.GetOrderDetailByCasedId(caseId);

            var notificationModel = new ReceiveNotificationModel();
            notificationModel.Title = "Level of Treatment มีการเปลี่ยนแปลง";
            notificationModel.Message = "Order " + orderDetail.OrderRef;
            notificationModel.Message += "\nคนไข้คุณ " + caseModel.PatientName;
            notificationModel.Message += "\nLevel of Treatment เปลี่ยนเป็น " + caseProduct.Product.Name;
            notificationModel.Message += "\n" + notificationText;
            notificationModel.userId = caseModel.UserId;

            int createNotiResult = await _notificationService.CreateNotificationAsync(caseModel.UserId, notificationModel);

            return caseProductUpdate;

        }

        public async Task<bool> UpdateCaseStatusToOrder(int caseId)
        {
            return await _caseRepo.UpdateCaseStatusToOrder(caseId);
        }

        public async Task<DuplicateCaseResponseModel> DuplicateCase(int caseId, int userId, int dentistId, int clinicId)
        {
            return await _caseRepo.DuplicateCase(caseId, userId, dentistId, clinicId);
        }

        private async Task<List<DisplayCaseModel>> FillNameWithERP(List<DisplayCaseModel> displayCaseModels)
        {

            if (displayCaseModels?.Count > 0)
            {
                List<int> dentistIds = new List<int>();
                List<int> clinicIds = new List<int>();

                List<ERP.Models.DoctorModel> doctors = null;
                List<ERP.Models.ContactModel> clinics = null;

                dentistIds = displayCaseModels.Select(s => s.DentistId).Distinct().ToList();
                clinicIds = displayCaseModels.Select(s => s.ClinicId).Distinct().ToList();

                if(dentistIds?.Count > 0)
                    doctors = await _netforceService.GetDoctorByIdsAsync(dentistIds);
                if (clinicIds?.Count > 0)
                    clinics = await _netforceService.GetContactByIdsAsync(clinicIds);

                foreach (DisplayCaseModel caseModel in displayCaseModels)
                {
                    caseModel.ClinicName = clinics.Find(d => d.Id == caseModel.ClinicId)?.Name;
                    caseModel.DentistName = doctors.Find(d => d.Id == caseModel.DentistId)?.Name;
                }
            }

            return displayCaseModels;
        }
    }
}
