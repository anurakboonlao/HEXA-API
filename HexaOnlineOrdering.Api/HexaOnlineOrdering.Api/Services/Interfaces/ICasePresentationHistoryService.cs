using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.CasePresentationHistory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface ICasePresentationHistoryService
    {
        public Task<CasePresentationHistoryModel> CreateCasePresentationHistoryAsync( AddCasePresentationHistoryModel model);
        public Task<List<CasePresentationHistoryModel>> GetCasePresentationHistoryAsync(int caseId, int orderId);
    }
}
