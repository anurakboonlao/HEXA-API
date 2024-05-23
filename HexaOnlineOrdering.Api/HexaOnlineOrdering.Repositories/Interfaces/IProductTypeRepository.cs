using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.MasterProduct;
using HexaOnlineOrdering.Repositories.DataModels;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IProductTypeRepository : IEntityBaseRepository<TblProductType, HexaDBContext>
    {
        Task<ProductTypeModel> GetProductTypeWithProductListById(int Id);
        Task<List<ProductGroupModel>> GetAllProductGroupModel();
        Task<List<CatalogModel>> GetCatalogByGroupId(int groupId);
        Task<List<TblProductType>> GetProductTypeByIdList(List<int> productTypeIdList);
    }
}
