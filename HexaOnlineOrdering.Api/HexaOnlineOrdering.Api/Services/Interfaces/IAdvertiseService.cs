using System.Collections.Generic;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IAdvertiseService
    {
        Task<List<AdvertiseModel>> GetAdsAll(bool? isActive = null);
        Task<AdvertiseModel> GetAdsById(int id);
        Task<AdvertiseModel> AddAds(AdvertiseModel ads);
        Task<int> EditAds(AdvertiseModel ads);
        Task<int> DeleteAdsById(int id);
        Task<int> GetDefaultOrderNumber();
        Task EditAdsList(List<AdvertiseModel> adsList);
    }
}
