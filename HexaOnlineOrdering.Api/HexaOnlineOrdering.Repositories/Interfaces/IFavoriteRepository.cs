using System.Threading.Tasks;
using HexaOnlineOrdering.Repositories.DataModels;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IFavoriteRepository : IEntityBaseRepository<TblFavorite, HexaDBContext>
    {
        Task<TblFavorite[]> GetFavorites(int userId, int productTypeId);
        Task<int> AddFavorite(TblFavorite entity);
        Task<int> DeleteFavorite(int id);
    }
}
