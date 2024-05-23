using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Case;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface ICaseService
    {
        Task<CaseModel> SaveCase(DisplayCaseModel caseData);
        Task<int> SaveCase(DraftCaseModel caseData);
        Task<CaseModel> UpdateCase(DisplayCaseModel caseData);
        Task<CaseModel> UpdateCaseMemoIcharm(int caseId, string model);
        Task<CaseManageModel> GetCaseListByDentistId(int dentistId, DateTime fromDate, DateTime endTime, int clinicId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId);
        Task<CaseManageModel> GetCaseListByClinicId(int clinicId, DateTime fromDate, DateTime endTime, int dentistId, int statusId, int page, int pageSize, string sortField, string sortOrder, string filterField, string filterText, int caseTypeId, int productTypeId);
        Task<DisplayCaseModel> GetCaseByCaseId(int caseId);
        Task DeleteCaseById(int caseId);
        Task<CaseModel> FindCaseHasOrderByCaseId(int caseId);
        Task<CaseProductModel> UpdateCaseProductIcharm(int caseId, int productId, string notificationText);
        Task<bool> SaveRequestDate(int caseId, DateTime? requestDate);
        Task<bool> UpdateCaseStatusToOrder(int caseId);

        Task<CaseModel> UpdateCaseAlignersIcharm(int caseId, string aligners);

        Task<DuplicateCaseResponseModel> DuplicateCase(int caseId, int userId, int dentistId, int clinicId);
    }
}
