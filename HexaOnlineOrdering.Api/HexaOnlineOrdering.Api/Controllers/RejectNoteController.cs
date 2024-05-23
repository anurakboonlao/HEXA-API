using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
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
    public class RejectNoteController : BaseController
    {
        private readonly IRejectNoteService _rejectNoteService;

        public RejectNoteController(IHttpContextAccessor httpContextAccessor, IRejectNoteService rejectNoteService) : base(httpContextAccessor)
        {
            _rejectNoteService = rejectNoteService ?? throw new ArgumentNullException(nameof(rejectNoteService));
        }

        [Authorize(Roles = "Admin,Staff,Dentist,Clinic")]
        [HttpPost("")]
        public async Task<RejectNoteModel> AddRejectNote([FromBody] AddRejectNoteModel model)
        {
            if (model == null)
                throw new HexaDomainException("Create RejectNote failed : Bad Request");

            if (model.OrderId == 0 && model.CaseId == 0)
                throw new HexaDomainException("Create RejectNote failed : Bad Request no caseId and orderId");


            string role = UserRole;
            bool isAdmin = (role == "Admin" || role == "Staff") ? true : false;

            RejectNoteModel rejectNoteModel = await _rejectNoteService.CreateRejectNoteAsync(CurrentUserId, model, isAdmin);

            if (rejectNoteModel.Id == 0)
                throw new HexaDomainException("Create RejectNote failed.");
            return rejectNoteModel;
        }
    }
}
