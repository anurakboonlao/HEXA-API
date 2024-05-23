using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.EntityFrameworkCore;
using HexaOnlineOrdering.Api.Extensions;
using AutoMapper;

namespace HexaOnlineOrdering.Api.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IFavoriteRepository _favRepo;
        private readonly IMapper _mapper;

        public FavoriteService(IFavoriteRepository favRepo, IMapper mapper)
        {
            _favRepo = favRepo ?? throw new ArgumentNullException(nameof(_favRepo));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<FavoriteModel[]> GetFavorites(int userId, int productTypeId)
        {
            TblFavorite[] favs = await _favRepo.GetFavorites(userId, productTypeId);
            FavoriteModel[] model = _mapper.Map<TblFavorite[], FavoriteModel[]>(favs);
            return model;
        }

        public async Task<int> AddFavorite(FavoriteModel model)
        {
            TblFavorite item = _mapper.Map<FavoriteModel, TblFavorite>(model);
            item.Materials = GetFavoriteMaterialsEntity(model);
            item.Designs = GetFavoriteDesignsEntity(model);
            item.AddOns = GetFavoriteAddOnEntity(model);
            int result = await _favRepo.AddFavorite(item);
            if (result > 0)
                model.Id = item.Id;
            return model.Id;
        }

        public async Task<int> RenameFavorite(int id, string name)
        {
            int result = 0;
            TblFavorite item = await _favRepo.GetAsync(i => i.Id == id);
            if (item != null)
            {
                item.Name = name;
                _favRepo.Update(item);
                result = await _favRepo.CommitAsync();
            }
            return result;
        }

        public async Task<int> DeleteFavorite(int id)
        {
            int result = await _favRepo.DeleteFavorite(id);
            return result;
        }

        private List<TblFavoriteMaterial> GetFavoriteMaterialsEntity (FavoriteModel model)
        {
            List<TblFavoriteMaterial> mats = new List<TblFavoriteMaterial>();
            if (model.MaterialModels != null && model.MaterialModels.Any())
            {
                foreach (FavoriteMaterialModel item in model.MaterialModels)
                {
                    mats.Add(new TblFavoriteMaterial() { MaterialId = item.MaterialId });
                }
            }
            return mats;
        }

        private List<TblFavoriteDesign> GetFavoriteDesignsEntity(FavoriteModel model)
        {
            List<TblFavoriteDesign> design = new List<TblFavoriteDesign>();
            if (model.DesignModels != null && model.DesignModels.Any())
            {
                foreach (FavoriteDesignModel item in model.DesignModels)
                {
                    design.Add(new TblFavoriteDesign() { DesignId = item.DesignId });
                }
            }
            return design;
        }

        private List<TblFavoriteAddOn> GetFavoriteAddOnEntity(FavoriteModel model)
        {
            List<TblFavoriteAddOn> addOns = new List<TblFavoriteAddOn>();
            if (model.AddOnModels != null && model.AddOnModels.Any())
            {
                foreach (FavoriteAddOnModel item in model.AddOnModels)
                {
                    addOns.Add(new TblFavoriteAddOn() { AddOnId = item.AddOnId, InputAddOn = item.InputAddOn });
                }
            }
            return addOns;
        }
    }
}
