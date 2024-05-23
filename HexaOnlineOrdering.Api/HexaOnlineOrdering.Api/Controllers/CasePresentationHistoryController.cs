using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.CasePresentationHistory;
using HexaOnlineOrdering.Models.RejectNote;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace HexaOnlineOrdering.Api.Controllers
{
    [Route("api/[controller]")]
    public class CasePresentationHistoryController : BaseController
    {
        private readonly ICasePresentationHistoryService _casePresentationHistoryService;


        public CasePresentationHistoryController(IHttpContextAccessor httpContextAccessor, ICasePresentationHistoryService casePresentationHistoryService) : base(httpContextAccessor)
        {
            _casePresentationHistoryService = casePresentationHistoryService ?? throw new ArgumentNullException(nameof(casePresentationHistoryService));
        }

        [Authorize(Roles = "Admin,Staff,Dentist,Clinic")]
        [HttpPost("")]
        public async Task<CasePresentationHistoryModel> AddCasePresentationHistory([FromBody] AddCasePresentationHistoryModel model)
        {
            if (model == null)
                throw new HexaDomainException("Create CasePresentationHistory failed : Bad Request");

            if (model.OrderId == 0 && model.CaseId == 0)
                throw new HexaDomainException("Create CasePresentationHistory failed : Bad Request no caseId and orderId");


            CasePresentationHistoryModel resultModel = await _casePresentationHistoryService.CreateCasePresentationHistoryAsync(model);

            if (resultModel.Id == 0)
                throw new HexaDomainException("Create CasePresentationHistory failed.");
            return resultModel;
        }

        [Authorize(Roles = "Admin,Staff,Dentist,Clinic")]
        [HttpGet("")]
        public async Task<List<CasePresentationHistoryModel>> GetCasePresentationHistory([FromQuery] int caseId, [FromQuery] int orderId)
        {
            if (caseId == 0 && orderId == 0)
                throw new HexaDomainException("Get CasePresentationHistory failed : Bad Request no caseId and orderId");


            List<CasePresentationHistoryModel> resultModel = await _casePresentationHistoryService.GetCasePresentationHistoryAsync(caseId,orderId);
            
            return resultModel;
        }
    }
}
