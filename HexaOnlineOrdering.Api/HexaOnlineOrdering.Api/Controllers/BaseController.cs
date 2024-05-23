using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using HexaOnlineOrdering.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HexaOnlineOrdering.Api.Controllers
{
    public class BaseController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public int CurrentUserId
        {
            get
            {
                if (_httpContextAccessor.HttpContext.User == null)
                    throw new UnauthorizedAccessException("User is not regcognize");

                return int.Parse(_httpContextAccessor.HttpContext.User.FindFirst("Id").Value);
            }
        }
        public string UserRole
        {
            get
            {
                if (_httpContextAccessor.HttpContext.User == null)
                    throw new UnauthorizedAccessException("User is not regcognize");

                ClaimsIdentity identity = _httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
                SubContactModel result = new SubContactModel();

                IEnumerable<Claim> claims = identity.Claims;
                return claims.First(c => c.Type == ClaimTypes.Role).Value;
      
            }
        }

        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
    }
}
