using System;
using System.Collections.Generic;
using System.Linq;
using HexaOnlineOrdering.Api.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HexaOnlineOrdering.Api.Filters
{
    public class CustomAuthorizationAttribute : Attribute, IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Microsoft.Extensions.Primitives.StringValues authKey = "";
            if(context.HttpContext.Request.Headers.TryGetValue("auth-key", out authKey))
            {
                var config = context.HttpContext.RequestServices.GetService<IConfiguration>();
                // Validate custom key from app settings.
                if (authKey[0] != config.GetValue<string>("ExternalKey"))
                    context.Result = new UnauthorizedResult();
            }
            else
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
