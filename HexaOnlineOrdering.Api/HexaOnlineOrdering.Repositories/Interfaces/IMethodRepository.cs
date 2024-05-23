using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IMethodRepository : IEntityBaseRepository<TblMethod, HexaDBContext>
    {
        Task<List<MethodModel>> GetMethodByTypeId(int typeId);
    }
}
