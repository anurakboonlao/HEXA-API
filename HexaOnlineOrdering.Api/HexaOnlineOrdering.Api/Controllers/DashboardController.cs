using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using HexaOnlineOrdering.Api.Exceptions;

namespace HexaOnlineOrdering.Api.Controllers
{
    
    [Route("api/[controller]")]
    public class DashboardController : BaseController
    {
        private readonly IOrdersService _orderService;

        public DashboardController(IHttpContextAccessor httpContextAccessor, IOrdersService orderService) : base(httpContextAccessor)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        [Authorize(Roles = "Clinic")]
        [HttpGet("DashboardClinic/{clinicId}")]
        public async Task<DashboardModel> DashboardClinic([FromRoute] int clinicId, DateTime startDate, DateTime endDate, int dentistId)
        {
            if(startDate.Date > endDate.Date)
                throw new HexaDomainException("From date must be less than to date.");

            DashboardModel model = await _orderService.GetClinicDashboard(clinicId, startDate, endDate, dentistId);
            return model;
        }

        [Authorize(Roles = "Dentist")]
        [HttpGet("DashboardDentist/{dentistId}")]
        public async Task<DashboardModel> DashboardDentist([FromRoute] int dentistId, DateTime startDate, DateTime endDate, int clinicId)
        {
            if (startDate.Date > endDate.Date)
                throw new HexaDomainException("From date must be less than to date.");

            DashboardModel model = await _orderService.GetDentistDashboard(dentistId, startDate, endDate, clinicId);
            return model;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpGet("DashboardAdmin")]
        public async Task<DashboardModel> DashboardAdmin(DateTime startDate, DateTime endDate)
        {
            if (startDate.Date > endDate.Date)
                throw new HexaDomainException("From date must be less than to date.");

            DashboardModel model = await _orderService.GetAdminDashboard( startDate, endDate);
            return model;
        }
    }
}
