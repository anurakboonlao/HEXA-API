using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Api.Options;
using HexaOnlineOrdering.Api.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http;
using HexaOnlineOrdering.ERP.Models;
using HexaOnlineOrdering.Api.Utils;
using HexaOnlineOrdering.Models.MasterProduct;
using HexaOnlineOrdering.Api.Exceptions;

namespace HexaOnlineOrdering.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly INetforceService _netforceService;
        private readonly IProductTypeService _productTypeService;

        public ProductController(IHttpContextAccessor httpContextAccessor, IProductService productService, IProductTypeService productTypeService, INetforceService netforceService) : base(httpContextAccessor)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _netforceService = netforceService ?? throw new ArgumentNullException(nameof(netforceService));
            _productTypeService = productTypeService ?? throw new ArgumentNullException(nameof(productTypeService));
        }

        [HttpGet("ImportProductFromERP")]
        [Authorize(Roles = "Admin,Staff")]
        public async Task<IActionResult> ImportProductFromERP()
        {
            List<QueryConditional> conditions = new List<QueryConditional>();
            List<ProductModel> erpProducts = await _netforceService.GetProductsAsync(conditions);
            await _productService.ImportProduct(erpProducts);
            return Ok();
        }

        [HttpGet("GetProductType/{typeId}")]
        [Authorize()]
        public async Task<IActionResult> GetProductType([FromRoute] int typeId)
        {
            ProductTypeModel result = await _productTypeService.GetProductTypeWithProductListById(typeId);
            return Ok(result);
        }

        [HttpGet("GetCatalog/{CatalogGroupId}")]
        [Authorize()]
        public async Task<IActionResult> GetCatalog([FromRoute] int CatalogGroupId)
        {
            List<CatalogModel> result = await _productTypeService.GetCatalogByGroupId(CatalogGroupId);

            if(result == null)
            {
                throw new HexaDomainException("CatalogModel is null");
            }
            return Ok(result);
        }
    }
}
