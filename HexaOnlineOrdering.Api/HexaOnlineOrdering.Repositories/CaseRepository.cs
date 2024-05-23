using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Case;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories
{
    public class CaseRepository : EntityBaseRepository<TblCase, HexaDBContext>, ICaseRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public CaseRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CaseModel> AddNewCase(DisplayCaseModel caseData)
        {
            if (caseData != null)
            {
                TblCase saveCase = new TblCase();
                saveCase.Id = 0;
                saveCase.CaseName = caseData.CaseName;
                saveCase.UserId = caseData.UserId;
                saveCase.PatientName = caseData.PatientName;
                saveCase.CreatedDate = DateTime.Now;
                saveCase.LastUpdate = DateTime.Now;
                saveCase.CaseStatusId = 1;
                saveCase.OrganizationId = caseData.ClinicId;
                saveCase.DoctorId = caseData.DentistId;
                saveCase.CaseTypeId = caseData.CaseTypeId;
                saveCase.ReferenceOrderId = null;
                saveCase.Memo = caseData.Memo;
                saveCase.Disabled = false;
                saveCase.RequestDate = caseData.RequestDate;
                saveCase.Age = caseData.Age;
                saveCase.Gender = caseData.Gender;

                if (caseData.AttachedFileList?.Count > 0)
                    saveCase.CaseAttachedFiles = _mapper.Map<List<CaseAttachedFileModel>, List<TblCaseAttachedFile>>(caseData.AttachedFileList);

                if (caseData.CaseOrderLists?.Count > 0)
                {
                    List<TblCaseProduct> caseProductList = new List<TblCaseProduct>();
                    foreach (CaseItemModel productItem in caseData.CaseOrderLists)
                    {
                        if (productItem.SelectProduct != null)
                        {
                            TblCaseProduct caseProduct = CustomMapping.CustomMapTblToModel.MapTblCaseProduct(productItem);
                            if(caseProduct != null)
                                caseProductList.Add(caseProduct);                         
                        }
                    }

                    saveCase.CaseProducts = caseProductList;
                }

                await AddAsync(saveCase);
                await CommitAsync();

                return _mapper.Map<TblCase, CaseModel>(saveCase);
            }
            return null;
        }

        public async Task<DisplayCaseModel> GetCaseByCaseId(int caseId)
        {
            TblCase caseTable = await _dbContext.Cases
                .Include(c => c.CaseStatus)
                .Include(c => c.CaseType)
                .Include(c => c.OrderData)
                .Include(c => c.CaseAttachedFiles)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Product).ThenInclude(p => p.Materials).ThenInclude(m => m.Material)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Product).ThenInclude(p => p.Designs).ThenInclude(m => m.Design)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Product).ThenInclude(p => p.AddOns).ThenInclude(m => m.AddOn)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Product).ThenInclude(p => p.AddOns).ThenInclude(m => m.GroupAddOn)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Materials).ThenInclude(pm => pm.Material)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Designs).ThenInclude(pm => pm.Design)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.AddOns).ThenInclude(pm => pm.AddOn)
                .Include(c => c.CaseProducts).ThenInclude(p => p.Method)
                .Include(c => c.CaseProducts).ThenInclude(p => p.ProductType)
                .Include(c => c.CaseProducts).ThenInclude(p => p.ShadeSystemObject)
                .Include(c => c.CaseProducts).ThenInclude(p => p.ShadeObject)
                .Where(c => c.Id == caseId).SingleOrDefaultAsync();

            DisplayCaseModel displayCase = CustomMapping.CustomMapTblToModel.MapDisplayCaseModel(caseTable);
            return displayCase;
        }

        private IQueryable<TblCase> filterCase(IQueryable<TblCase> caseQuery, string filterField, string filterText)
        {

            if (!string.IsNullOrEmpty(filterText))
            {
                switch (filterField.ToLower())
                {
                    case "patient":
                        caseQuery = caseQuery.Where(p => p.PatientName.Contains(filterText));
                        break;
                    //case "case type":
                    //    caseQuery = caseQuery.Where(p => p.CaseType.Name.Contains(filterText));
                    //    break;
                    //case "product type":
                    //    caseQuery = caseQuery.Where(p => p.CaseProducts.Any(d=>d.ProductType.Name.Contains(filterText)));
                    //    break;
                    //default:
                    //    //all
                    //    caseQuery = caseQuery.Where(p => p.PatientName.Contains(filterText));
                    //    break;
                }
            }

         

            return caseQuery;
        }

        private IQueryable<TblCase> sortCase(IQueryable<TblCase> caseQuery, string sortField, string sortOrder)
        {
            if (!string.IsNullOrEmpty(sortField) && !string.IsNullOrEmpty(sortOrder))
            {
                if (sortOrder == "desc")
                {
                    switch (sortField.ToLower())
                    {
                        case "patientname":
                            caseQuery = caseQuery.OrderByDescending(p => p.PatientName);
                            break;
                        case "lastupdate":
                            caseQuery = caseQuery.OrderByDescending(p => p.LastUpdate);
                            break;
                        case "producttype":
                            caseQuery = caseQuery.OrderByDescending(p=> p.CaseProducts.OrderByDescending(c=>c.ProductType.Name).Select(c => c.ProductType.Name).FirstOrDefault());
                            break;                      
                        case "casetype":
                            caseQuery = caseQuery.OrderByDescending(p => p.CaseType.Name);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (sortField.ToLower())
                    {
                        case "patientname":
                            caseQuery = caseQuery.OrderBy(p => p.PatientName);
                            break;
                        case "lastupdate":
                            caseQuery = caseQuery.OrderBy(p => p.LastUpdate);
                            break;
                        case "producttype":
                            caseQuery = caseQuery.OrderBy(p => p.CaseProducts.OrderBy(c => c.ProductType.Name).Select(c => c.ProductType.Name).FirstOrDefault());
                            break;                  
                        case "casetype":
                            caseQuery = caseQuery.OrderBy(p => p.CaseType.Name);
                            break;
                        default:
                            break;
                    }
                }
            }
            return caseQuery;
        }
        public async Task<CaseManageModel> GetCaseListByClinicId(int clinicId, DateTime fromDate, DateTime endTime, int dentistId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId)
        {
            IQueryable<TblCase> caseQuery = _dbContext.Cases
                .Include(c => c.CaseStatus)
                .Include(c => c.CaseType)
                .Include(c => c.CaseProducts).ThenInclude(p => p.Method)
                .Include(c => c.CaseProducts).ThenInclude(p => p.ProductType)
                .Where(c => c.OrganizationId.HasValue && c.OrganizationId.Value == clinicId
                && c.LastUpdate.Date >= fromDate.Date && c.LastUpdate.Date <= endTime.Date
                && (dentistId == 0 || c.DoctorId == dentistId)
                && (statusId == 0 || c.CaseStatusId == statusId)
                && (caseTypeId == 0 || c.CaseTypeId == caseTypeId)
                && (productTypeId == 0 || c.CaseProducts.Any(d => d.ProductTypeId == productTypeId)));

            caseQuery = filterCase(caseQuery, filterField, filterText);

            int totalFilterRow = caseQuery.Count();

            caseQuery = sortCase(caseQuery, sortField, sortOrder);
            int skip = (page - 1) * pageSize;
            List<TblCase> cases = await caseQuery.Skip(skip).Take(pageSize).ToListAsync();

            List<DisplayCaseModel> displayCases = new List<DisplayCaseModel>();
            if (cases?.Count > 0)
            {
                foreach (TblCase item in cases)
                {
                    DisplayCaseModel displayCase = CustomMapping.CustomMapTblToModel.MapDisplayCaseModel(item);
                    if (displayCase != null)
                        displayCases.Add(displayCase);
                }
            }

            CaseManageModel model = new CaseManageModel();
            model.TotalFilterRow = totalFilterRow;
            model.CaseList = displayCases;
            return model;
        }

        public async Task<CaseManageModel> GetCaseListByDentistId(int dentistId, DateTime fromDate, DateTime endTime, int clinicId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId)
        {
              IQueryable<TblCase> caseQuery = _dbContext.Cases
             .Include(c => c.CaseStatus)
             .Include(c => c.CaseType)
             .Include(c => c.CaseProducts).ThenInclude(p => p.Method)
             .Include(c => c.CaseProducts).ThenInclude(p => p.ProductType)
             .Where(c => c.DoctorId.HasValue && c.DoctorId.Value == dentistId
              && c.LastUpdate.Date >= fromDate.Date && c.LastUpdate.Date <= endTime.Date
              && (clinicId == 0 || c.OrganizationId == clinicId)
              && (statusId == 0 || c.CaseStatusId == statusId)
              && (caseTypeId == 0 || c.CaseTypeId == caseTypeId)
              && (productTypeId == 0 || c.CaseProducts.Any(d => d.ProductTypeId == productTypeId)));


            caseQuery = filterCase(caseQuery, filterField, filterText);

            int totalFilterRow = caseQuery.Count();

            caseQuery = sortCase(caseQuery, sortField, sortOrder);
            int skip = (page - 1) * pageSize;


            List<TblCase> cases = await caseQuery.Skip(skip).Take(pageSize).ToListAsync();

            List <DisplayCaseModel> displayCases = new List<DisplayCaseModel>();
            if (cases?.Count > 0)
            {
                foreach (TblCase item in cases)
                {
                    DisplayCaseModel displayCase = CustomMapping.CustomMapTblToModel.MapDisplayCaseModel(item);
                    if (displayCase != null)
                        displayCases.Add(displayCase);
                }
            }

            CaseManageModel model = new CaseManageModel();
            model.TotalFilterRow = totalFilterRow;
            model.CaseList = displayCases;
            return model;
        }

        public async Task<TblCase> GetCaseForUpdate(int caseId)
        {
            TblCase caseTable = await _dbContext.Cases
                .Include(c => c.CaseAttachedFiles)
                .Include(c => c.CaseProducts)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Materials)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Designs)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.AddOns)
                .Include(c => c.CaseProducts).ThenInclude(p => p.Method)
                .Include(c => c.CaseProducts).ThenInclude(p => p.ProductType)
                .Where(c => c.Id == caseId).SingleOrDefaultAsync();

            return caseTable;
        }

        public async Task<CaseModel> GetCaseHasOrderByCaseId(int caseId)
        {
            TblCase caseTable = await _dbContext.Cases.Where(c => c.Id == caseId && c.CaseStatusId == 2).SingleOrDefaultAsync();
            return _mapper.Map<TblCase, CaseModel>(caseTable);
        }

        public async Task<bool> UpdateCaseStatusToOrder(int caseId)
        {
            TblCase caseTable = await _dbContext.Cases.Where(c => c.Id == caseId).SingleOrDefaultAsync();
            caseTable.CaseStatusId = 2;
            int row = await CommitAsync();
            return row>0;
        }

        public async Task<int> AddDraftCase(DraftCaseModel caseDisplay)
        {
            if (caseDisplay != null)
            {
                TblCase saveCase = new TblCase();
                saveCase.Id = 0;
                saveCase.CaseName = string.Empty;
                saveCase.UserId = caseDisplay.UserId;
                saveCase.PatientName = caseDisplay.PatientName ?? "";
                saveCase.CreatedDate = DateTime.Now;
                saveCase.LastUpdate = DateTime.Now;
                saveCase.CaseStatusId = 1; // draft
                saveCase.OrganizationId = caseDisplay.ClinicId;
                saveCase.DoctorId = caseDisplay.DentistId;
                saveCase.CaseTypeId = caseDisplay.CaseTypeId;
                saveCase.Memo = string.Empty;
                saveCase.Disabled = false;
                saveCase.ReferenceOrderId = caseDisplay.OrderId ?? null;
                saveCase.ReferenceOrderNumber = caseDisplay.OrderRef;
                saveCase.Age = caseDisplay.Age;
                saveCase.Gender = caseDisplay.Gender;

                await AddAsync(saveCase);
                await CommitAsync();

                return saveCase.Id;
            }
            return -1;
        }

        public async Task<List<TblCase>> GetClinicCaseForDashboard(int clinicId, DateTime from, DateTime to, int dentistId)
        {
            List<TblCase> caseTable = await _dbContext.Cases
                .Where(c => c.OrganizationId.HasValue && c.OrganizationId.Value == clinicId 
                && c.CreatedDate.Date >= from.Date && c.CreatedDate.Date <= to.Date
                && (dentistId == 0 || c.DoctorId == dentistId)).ToListAsync();
            return caseTable;
        }

        public async Task<List<TblCase>> GetDentistCaseForDashboard(int dentistId, DateTime from, DateTime to, int clinicId)
        {
            List<TblCase> caseTable = await _dbContext.Cases
               .Where(c => c.DoctorId.HasValue && c.DoctorId.Value == dentistId 
               && c.CreatedDate.Date >= from.Date && c.CreatedDate.Date <= to.Date
               && (clinicId == 0 || c.OrganizationId == clinicId)).ToListAsync();
            return caseTable;
        }

        public async Task<DuplicateCaseResponseModel> DuplicateCase(int caseId, int userId, int dentistId, int clinicId)
        {
            TblCase caseTable = await _dbContext.Cases
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Materials)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.Designs)
                .Include(c => c.CaseProducts).ThenInclude(cp => cp.AddOns)
                .Include(c => c.CaseProducts).ThenInclude(p => p.Method)
                .Where(c => c.Id == caseId).SingleOrDefaultAsync();

            if(caseTable == null)
                return new DuplicateCaseResponseModel(false, "No case source", 0);
            else
            {
                TblCase newCase = new TblCase();
                newCase.Id = 0;
                newCase.CaseName = string.Empty;
                newCase.UserId = userId;
                newCase.PatientName = string.Empty;
                newCase.CreatedDate = DateTime.Now;
                newCase.LastUpdate = DateTime.Now;
                newCase.CaseStatusId = 1; // draft
                newCase.OrganizationId = clinicId;
                newCase.DoctorId = dentistId;
                newCase.CaseTypeId = 1;
                newCase.ReferenceOrderId = null;
                newCase.Memo = string.Empty;
                newCase.Disabled = false;

                List<TblCaseProduct> caseProducts = new List<TblCaseProduct>();
                if(caseTable.CaseProducts?.Count > 0)
                {
                    foreach (TblCaseProduct oldCaseProduct in caseTable.CaseProducts)
                    {
                        TblCaseProduct caseProduct = new TblCaseProduct();
                        caseProduct.ProductTypeId = oldCaseProduct.ProductTypeId;
                        caseProduct.MethodId = oldCaseProduct.MethodId;
                        caseProduct.TeethNumber = oldCaseProduct.TeethNumber;
                        caseProduct.Section = oldCaseProduct.Section;
                        caseProduct.ProductId = oldCaseProduct.ProductId;
                        caseProduct.Qty = oldCaseProduct.Qty;
                        caseProduct.Quadrant = oldCaseProduct.Quadrant;
                        caseProduct.Option = oldCaseProduct.Option;
                        caseProduct.Shade = oldCaseProduct.Shade;
                        caseProduct.ShadeSystem = oldCaseProduct.ShadeSystem;
                      
                        if(oldCaseProduct.Materials?.Count > 0)
                        {
                            List<TblCaseProductMaterial> materials = new List<TblCaseProductMaterial>();
                            foreach (TblCaseProductMaterial oldMaterial in oldCaseProduct.Materials)
                            {
                                TblCaseProductMaterial material = new TblCaseProductMaterial();
                                material.MaterialId = oldMaterial.MaterialId;
                                materials.Add(material);
                            }
                            caseProduct.Materials = materials;
                        }

                        if (oldCaseProduct.Designs?.Count > 0)
                        {
                            List<TblCaseProductDesign> designs = new List<TblCaseProductDesign>();
                            foreach (TblCaseProductDesign oldDesigns in oldCaseProduct.Designs)
                            {
                                TblCaseProductDesign design = new TblCaseProductDesign();
                                design.DesignId = oldDesigns.DesignId;
                                designs.Add(design);
                            }
                            caseProduct.Designs = designs;
                        }

                        if (oldCaseProduct.AddOns?.Count > 0)
                        {
                            List<TblCaseProductAddOn> addOns = new List<TblCaseProductAddOn>();
                            foreach (TblCaseProductAddOn oldAddOns in oldCaseProduct.AddOns)
                            {
                                TblCaseProductAddOn addOn = new TblCaseProductAddOn();
                                addOn.AddOnId = oldAddOns.AddOnId;
                                addOn.InputAddOn = oldAddOns.InputAddOn;
                                addOns.Add(addOn);
                            }
                            caseProduct.AddOns = addOns;
                        }
                        caseProducts.Add(caseProduct);
                    }
                }
                newCase.CaseProducts = caseProducts;

                await AddAsync(newCase);
                int number = await CommitAsync();
                if(number > 0)
                {
                    return new DuplicateCaseResponseModel(true, "", newCase.Id);
                }
                else
                {
                    return new DuplicateCaseResponseModel(false, "Duplicate Case Failed", 0);
                }
                
            }
        }
    }
}
