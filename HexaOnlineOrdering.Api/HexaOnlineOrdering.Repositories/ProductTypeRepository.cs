using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.MasterProduct;
using HexaOnlineOrdering.Repositories.CustomMapping;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories
{
    public class ProductTypeRepository : EntityBaseRepository<TblProductType, HexaDBContext>, IProductTypeRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public ProductTypeRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<TblProductType>> GetProductTypeByIdList(List<int> productTypeIdList)
        {
            List<TblProductType> productType = await _dbContext.ProductTypes.Where(p => productTypeIdList.Contains(p.Id)).ToListAsync();
            return productType;
        }

        public async Task<ProductTypeModel> GetProductTypeWithProductListById(int id)
        {
            TblProductType productType = await _dbContext.ProductTypes.Include(t => t.Methods)
                                                .Include(t => t.ShadeSystems).ThenInclude(tg => tg.Shades)
                                                .Include(t => t.ProductTypeGroups).ThenInclude(tg=>tg.ProductGroupItems)
                                                    .ThenInclude(p => p.Product).ThenInclude(p => p.Materials).ThenInclude(m=>m.Material)
                                                .Include(t => t.ProductTypeGroups).ThenInclude(tg => tg.ProductGroupItems)
                                                    .ThenInclude(p => p.Product).ThenInclude(p => p.Designs).ThenInclude(m => m.Design)
                                                .Include(t => t.ProductTypeGroups).ThenInclude(tg => tg.ProductGroupItems)
                                                    .ThenInclude(p => p.Product).ThenInclude(p => p.AddOns).ThenInclude(m => m.AddOn)
                                                .Include(t => t.ProductTypeGroups).ThenInclude(tg => tg.ProductGroupItems)
                                                    .ThenInclude(p => p.Product).ThenInclude(p => p.AddOns).ThenInclude(g => g.GroupAddOn)
                                                .SingleOrDefaultAsync(t => t.Id == id);

            ProductTypeModel model = null;
            if (productType != null)
                model = CustomMapTblToModel.MapProductTypeModel(productType);             

            return model;
        }

        public async Task<List<ProductGroupModel>> GetAllProductGroupModel()
        {
            List<TblProductTypeGroup> productTypeGroups = await _dbContext.ProductTypeGroups.Include(t => t.ProductGroupItems).ThenInclude(i => i.Product).ToListAsync();

            List<ProductGroupModel> models = new List<ProductGroupModel>();
            foreach (TblProductTypeGroup productTypeGroup in productTypeGroups.OrderBy(o => o.OrderNumber))
            {
                ProductGroupModel productGroup = CustomMapTblToModel.MapProductGroupModel(productTypeGroup);
                if (productGroup != null && productGroup.ProductItems != null && productGroup.ProductItems.Count > 0)
                    models.Add(productGroup);
            }

            return models;
        }

        public async Task<List<CatalogModel>> GetCatalogByGroupId(int groupId)
        {
            List<TblCatalog> tblCatalogs = new List<TblCatalog>();
            // if group Id = 0 , get all catalogs
            if(groupId == 0)
            {
                tblCatalogs = await _dbContext.Catalogs.Include(catalog => catalog.CatalogGroup)
                    .Where(catalog => catalog.Disabled == false).OrderBy(catalog => catalog.OrderNumber).ToListAsync();
            }
            else
            {
                tblCatalogs = await _dbContext.Catalogs.Include(catalog => catalog.CatalogGroup)
                    .Where(catalog => catalog.CatalogGroupId == groupId && catalog.Disabled == false).OrderBy( catalog => catalog.OrderNumber).ToListAsync();
            }

            //mapping catalog to model
            if(tblCatalogs == null)
            {
                return null;
            }

            List<CatalogModel> catalogModels = new List<CatalogModel>();
            foreach (TblCatalog tblCatalog in tblCatalogs)
            {
                CatalogModel catalogModel = new CatalogModel();
                catalogModel.Id = tblCatalog.Id;
                catalogModel.Name = tblCatalog.Name;
                catalogModel.LogoPath = tblCatalog.LogoPath;
                catalogModel.OrderNumber = tblCatalog.OrderNumber;
                catalogModel.CatalogGroupId = tblCatalog.CatalogGroupId;
                catalogModel.CatalogGroupName = tblCatalog.CatalogGroup.Name;
                catalogModels.Add(catalogModel);
            }

            return catalogModels;
        }
    }
}
