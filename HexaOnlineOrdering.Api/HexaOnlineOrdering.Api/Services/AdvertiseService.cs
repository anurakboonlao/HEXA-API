using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Extensions;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.Interfaces;
using HexaOnlineOrdering.Repositories.DataModels;
using AutoMapper;

namespace HexaOnlineOrdering.Api.Services
{
    public class AdvertiseService : IAdvertiseService
    {
        private readonly IAdvertiseRepository _adsRepo;
        private readonly IMapper _mapper;


        public AdvertiseService(IAdvertiseRepository adsRepo, IMapper mapper)
        {
            _adsRepo = adsRepo ?? throw new ArgumentNullException(nameof(adsRepo));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<AdvertiseModel>> GetAdsAll(bool? isActive = null)
        {
            List<TblAds> ads = isActive != null ? _adsRepo.GetAll().Where(c => c.Disabled == !isActive.Value).OrderBy(o => o.OrderNumber).ToList()
                : _adsRepo.GetAll().OrderBy(o => o.OrderNumber).ToList();

            return _mapper.Map<List<TblAds>, List<AdvertiseModel>>(ads);
        }

        public async Task<AdvertiseModel> GetAdsById(int id)
        {
            TblAds ads = await _adsRepo.GetAsync(i => i.Id == id);
            return _mapper.Map<TblAds, AdvertiseModel>(ads);
        }

        public async Task<int> GetDefaultOrderNumber()
        {
            var ads = _adsRepo.GetAll();
            int maxOrder = ads.Count() > 0 ? _adsRepo.GetAll().Max(i => i.OrderNumber) : 0;
            return maxOrder + 1;
        }

        public async Task<AdvertiseModel> AddAds(AdvertiseModel model)
        {
            TblAds ent = _mapper.Map<AdvertiseModel, TblAds>(model);
            ent.CreatedDate = DateTime.Now;
            _adsRepo.Add(ent);
            int result = await _adsRepo.CommitAsync();
            if (result > 0)
                model.Id = ent.Id;

            return model;
        }

        public async Task<int> EditAds(AdvertiseModel model)
        {
            TblAds oldAds = _adsRepo.Get(i => i.Id == model.Id);
            if (oldAds != null)
            {
                oldAds.Name = model.Name;
                oldAds.Disabled = model.Disabled;
                oldAds.FilePath = model.FilePath;
                oldAds.OrderNumber = model.OrderNumber;
                oldAds.URL = model.Url;

                _adsRepo.Update(oldAds);
                return await _adsRepo.CommitAsync();
            }

            return 0;
        }

        public async Task<int> DeleteAdsById(int id)
        {
            _adsRepo.DeleteWithCondition(i => i.Id == id);
            return await _adsRepo.CommitAsync();
        }

        public async Task EditAdsList(List<AdvertiseModel> adsList)
        {
            foreach (var ads in adsList)
            {
                var existingAds = await _adsRepo.GetAsync(c => c.Id == ads.Id);
                if (existingAds != null)
                {
                    existingAds.Name = ads.Name;
                    existingAds.Disabled = ads.Disabled;
                    existingAds.FilePath = ads.FilePath;
                    existingAds.OrderNumber = ads.OrderNumber;
                    existingAds.URL = ads.Url;

                    _adsRepo.Update(existingAds);
                }
            }

            await _adsRepo.CommitAsync();
        }
    }
}
