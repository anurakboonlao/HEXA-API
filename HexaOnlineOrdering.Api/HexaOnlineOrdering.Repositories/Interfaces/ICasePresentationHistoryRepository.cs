
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.CasePresentationHistory;
using HexaOnlineOrdering.Repositories.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface ICasePresentationHistoryRepository : IEntityBaseRepository<TblCasePresentationHistory, HexaDBContext>
    {
        public Task<int> CreateCasePresentationHistoryAsync(CasePresentationHistoryModel model);
        public Task<CasePresentationHistoryModel> GetLastCasePresentationHistoryAsync(int caseId);
        public Task<List<CasePresentationHistoryModel>> GetCasePresentationHistoryByCaseIdAsync(int caseId);
    }
}
