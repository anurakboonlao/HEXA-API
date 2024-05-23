using HexaOnlineOrdering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IFavoriteService
    {
        Task<FavoriteModel[]> GetFavorites(int userId, int productTypeId);
        Task<int> AddFavorite(FavoriteModel model);
        Task<int> RenameFavorite(int id, string name);
        Task<int> DeleteFavorite(int id);
    }
}
