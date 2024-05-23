using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.MasterProduct;
using HexaOnlineOrdering.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services
{
    public class ProductTypeService: IProductTypeService
    {
        private readonly IProductTypeRepository _productTypeRepo;
        private readonly IAWS3service _aws3service;

        public ProductTypeService(IProductTypeRepository productTypeRepo, IAWS3service aws3Service)
        {
            _productTypeRepo = productTypeRepo ?? throw new ArgumentNullException(nameof(productTypeRepo));
            _aws3service = aws3Service ?? throw new ArgumentNullException(nameof(aws3Service));
        }
        public async Task<ProductTypeModel> GetProductTypeWithProductListById(int id)
        {
            ProductTypeModel productType = await _productTypeRepo.GetProductTypeWithProductListById(id);
            if(productType?.ProductGroupModels?.Count > 0)
            {
                foreach (ProductGroupModel group in productType.ProductGroupModels)
                {
                    if(group?.ProductItems?.Count > 0)
                    {
                        foreach (MasterProductModel product in group.ProductItems)
                        {
                            product.LogoPath = _aws3service.GenerateAwsRegularFileUrl(product.LogoPath);
                            if (product?.Materials?.Count > 0)
                            {
                                foreach (MaterialModel material in product.Materials)
                                {
                                    material.LogoPath = _aws3service.GenerateAwsRegularFileUrl(material.LogoPath);
                                }
                            }
                            if (product?.Designs?.Count > 0)
                            {
                                foreach (DesignModel design in product.Designs)
                                {
                                    design.LogoPath = _aws3service.GenerateAwsRegularFileUrl(design.LogoPath);
                                }
                            }
                            if (product?.AddOnGroups?.Count > 0)
                            {
                                foreach (GroupAddOnModel addOnGroup in product.AddOnGroups)
                                {
                                    foreach (AddOnModel addOn in addOnGroup.AddOns)
                                    {
                                        addOn.LogoPath = _aws3service.GenerateAwsRegularFileUrl(addOn.LogoPath);
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }

            return productType;
        }

        public async Task<List<CatalogModel>> GetCatalogByGroupId(int groupId)
        {
            List<CatalogModel> catalogModels = await _productTypeRepo.GetCatalogByGroupId(groupId);
            if(catalogModels == null)
            {
                return null;
            }
            
            // combine logo path 
            foreach (CatalogModel catalogModel in catalogModels)
            {
                catalogModel.LogoPath = _aws3service.GenerateAwsRegularFileUrl(catalogModel.LogoPath);
            }
            return catalogModels;
        }
    }
}
