using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HexaOnlineOrdering.ERP.Models;
using Microsoft.AspNetCore.Http;
using HexaOnlineOrdering.Api.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HexaOnlineOrdering.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,Staff")]
    public class UserController : BaseController
    {
        #region Fields
        private readonly IUserService _userService;
        private readonly IDoctorService _doctorService;
        private readonly INetforceService _netforceService;
        #endregion
        public UserController(IUserService userService, IDoctorService doctorService, INetforceService netforceService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _doctorService = doctorService ?? throw new ArgumentNullException(nameof(doctorService));
            _netforceService = netforceService ?? throw new ArgumentNullException(nameof(netforceService));
        }

        [HttpGet("GetUsers")]
        public async Task<List<UserModel>> GetUsers()
        {
            return await _userService.GetAllUser();
        }

        [HttpGet("GetDoctors")]
        public List<Models.DoctorModel> GetAllDoctors()
        {
            return _doctorService.GetAllDoctors();
        }

        [HttpGet("Erp")]
        public async Task<List<ProductModel>> GetErp()
        {
            List<QueryConditional> conditions = new List<QueryConditional>();
            conditions.Add(new QueryConditional() { FieldName = "id", Operator = OperatorType.EQUAL, Value = 36134 });
            List<ProductModel> products = await _netforceService.GetProductsAsync(conditions);
            return products;
        }
    }
}
