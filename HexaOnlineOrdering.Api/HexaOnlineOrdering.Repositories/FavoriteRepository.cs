using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;

namespace HexaOnlineOrdering.Repositories
{
    public class FavoriteRepository : EntityBaseRepository<TblFavorite, HexaDBContext>, IFavoriteRepository
    {
        private readonly HexaDBContext _dbContext;

        public FavoriteRepository(HexaDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }

        public async Task<TblFavorite[]> GetFavorites(int userId, int productTypeId)
        {
            return await _dbContext.Favorites.Where(f => f.UserId == userId && f.ProductTypeId == productTypeId)
                .Include(f => f.Materials).ThenInclude(g => g.Material)
                .Include(f => f.Designs).ThenInclude(g => g.Design)
                .Include(f => f.AddOns).ThenInclude(g => g.AddOn)
                .Include(f => f.Product)
                .ToArrayAsync();
        }

        public async Task<int> AddFavorite(TblFavorite entity)
        {
            await _dbContext.Favorites.AddAsync(entity);
            int result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteFavorite(int id)
        {
            var mats = _dbContext.FavoriteMaterials.Where(i => i.FavoriteId == id);
            if (mats != null && mats.Any())
                _dbContext.FavoriteMaterials.RemoveRange(mats);

            var designs = _dbContext.FavoriteDesigns.Where(i => i.FavoriteId == id);
            if (designs != null && designs.Any())
                _dbContext.FavoriteDesigns.RemoveRange(designs);

            var addOns = _dbContext.FavoriteAddOns.Where(i => i.FavoriteId == id);
            if (addOns != null && addOns.Any())
                _dbContext.FavoriteAddOns.RemoveRange(addOns);

            var item = _dbContext.Favorites.SingleOrDefault(i => i.Id == id);
            if (item != null)
                _dbContext.Favorites.Remove(item);
            int result = await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
