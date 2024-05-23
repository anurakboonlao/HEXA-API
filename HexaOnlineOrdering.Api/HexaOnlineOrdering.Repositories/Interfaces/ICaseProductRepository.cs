using System.Collections.Generic;
using System.Threading.Tasks;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface ICaseProductRepository : IEntityBaseRepository<TblCaseProduct, HexaDBContext>
    {
        Task<TblCaseProduct> GetCaseProductByCaseId(int caseId);
        Task<CaseProductModel> UpdateProductByCaseId(int caseId, int productId);
    }
}
