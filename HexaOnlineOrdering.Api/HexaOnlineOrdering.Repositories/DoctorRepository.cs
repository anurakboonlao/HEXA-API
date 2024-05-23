using System;
using HexaOnlineOrdering.Repositories.EOrderDataModels;
using HexaOnlineOrdering.Repositories.Interfaces;

namespace HexaOnlineOrdering.Repositories
{
    public class DoctorRepository : EntityBaseRepository<Doctor, EOrderDBContext>, IDoctorRepository
    {
        private readonly EOrderDBContext _dbContext;

        public DoctorRepository(EOrderDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
