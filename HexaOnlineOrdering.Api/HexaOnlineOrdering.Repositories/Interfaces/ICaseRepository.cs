using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Case;
using HexaOnlineOrdering.Repositories.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface ICaseRepository : IEntityBaseRepository<TblCase, HexaDBContext>
    {
        Task<CaseModel> AddNewCase(DisplayCaseModel caseDisplay);
        Task<int> AddDraftCase(DraftCaseModel caseDisplay);
        Task<CaseManageModel> GetCaseListByDentistId(int dentistId, DateTime fromDate, DateTime endTime, int clinicId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId);
        Task<CaseManageModel> GetCaseListByClinicId(int clinicId, DateTime fromDate, DateTime endTime, int dentistId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId);
        Task<DisplayCaseModel> GetCaseByCaseId(int caseId);
        Task<TblCase> GetCaseForUpdate(int caseId);

        Task<CaseModel> GetCaseHasOrderByCaseId(int caseId);

        Task<bool> UpdateCaseStatusToOrder(int caseId);

        Task<List<TblCase>> GetClinicCaseForDashboard(int clinicId, DateTime from, DateTime to, int dentistId);
        Task<List<TblCase>> GetDentistCaseForDashboard(int dentistId, DateTime from, DateTime to, int clinicId);

        Task<DuplicateCaseResponseModel> DuplicateCase(int caseId, int userId, int dentistId, int clinicId);
    }
}
