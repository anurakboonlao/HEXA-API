using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories
{
    public class ProductRepository : EntityBaseRepository<TblProduct, HexaDBContext>, IProductRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public ProductRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task ImportProduct(List<ProductModel> products)
        {
            if (products != null && products.Count > 0)
            {
                List<TblProduct> addProducts = new List<TblProduct>();
                List<TblProduct> editProducts = new List<TblProduct>();
                List<TblProduct> dbProsucts = GetAll().ToList();
                foreach (ProductModel product in products)
                {
                    if (dbProsucts != null && dbProsucts.Count > 0)
                    {
                        TblProduct found = dbProsucts.Where(p => p.Code == product.Code).SingleOrDefault();
                        if (found != null)
                        {
                            // found Edit
                            if (found.Name != product.Name)
                            {
                                //update name
                                found.Name = product.Name;
                                editProducts.Add(found);
                            }
                            continue;
                        }
                    }
                    //create new
                    TblProduct newProduct = new TblProduct();
                    newProduct.Code = product.Code;
                    newProduct.Name = product.Name;
                    newProduct.DisplayName = product.Name;
                    newProduct.ColorCode = string.Empty;
                    newProduct.LogoPath = string.Empty;
                    newProduct.EOrderProductId = 0;
                    newProduct.UnitId = 1;
                    newProduct.ProductCategoryId = 1;

                    addProducts.Add(newProduct);
                }

                if (addProducts != null && addProducts.Count > 0)
                {
                    AddRange(addProducts);
                    await CommitAsync();
                }
                if (editProducts != null && editProducts.Count > 0)
                {
                    foreach (TblProduct updateProduct in editProducts)
                    {
                        Update(updateProduct);
                    }
                    await CommitAsync();
                }
            }
        }


    }
}
