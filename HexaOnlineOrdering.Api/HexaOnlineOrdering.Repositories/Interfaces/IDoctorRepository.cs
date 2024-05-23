using System;
using HexaOnlineOrdering.Repositories.EOrderDataModels;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IDoctorRepository : IEntityBaseRepository<Doctor, EOrderDBContext>
    {
    }
}
