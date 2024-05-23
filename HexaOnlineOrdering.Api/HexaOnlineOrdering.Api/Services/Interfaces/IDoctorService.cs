using System;
using System.Collections.Generic;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IDoctorService
    {
        List<DoctorModel> GetAllDoctors();
    }
}
