using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IProductRepository : IEntityBaseRepository<TblProduct, HexaDBContext>
    {
        Task ImportProduct(List<ProductModel> products);
    }
}
