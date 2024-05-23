using System;
using System.Collections.Generic;
using HexaOnlineOrdering.Api.Extensions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.Interfaces;

namespace HexaOnlineOrdering.Api.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepo;

        public DoctorService(IDoctorRepository doctorRepo)
        {
            _doctorRepo = doctorRepo ?? throw new ArgumentNullException(nameof(doctorRepo));
        }

        public List<DoctorModel> GetAllDoctors()
        {
            return _doctorRepo.GetAll().MapToList<DoctorModel>();
        }
    }
}
