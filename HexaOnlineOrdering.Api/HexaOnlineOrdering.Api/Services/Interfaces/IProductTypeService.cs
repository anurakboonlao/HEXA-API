using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.MasterProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IProductTypeService
    {
        Task<ProductTypeModel> GetProductTypeWithProductListById(int id);
        Task<List<CatalogModel>> GetCatalogByGroupId(int groupId);
    }
}
