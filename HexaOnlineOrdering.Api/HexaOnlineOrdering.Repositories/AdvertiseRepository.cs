using System;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;

namespace HexaOnlineOrdering.Repositories
{
    public class AdvertiseRepository : EntityBaseRepository<TblAds, HexaDBContext>, IAdvertiseRepository
    {
        private readonly HexaDBContext _dbContext;

        public AdvertiseRepository(HexaDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }
    }
}
