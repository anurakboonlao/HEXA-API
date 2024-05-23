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
    [Authorize(Roles = "Dentist,Clinic")]
    [Route("api/[controller]")]
    public class FavoriteController : BaseController
    {
        private readonly IFavoriteService _favService;

        public FavoriteController(IHttpContextAccessor httpContextAccessor, IFavoriteService favService) : base(httpContextAccessor)
        {
            _favService = favService ?? throw new ArgumentNullException(nameof(favService));
        }

        [HttpGet("GetFavorites")]
        public async Task<FavoriteModel[]> GetFavorites(int userId, int productTypeId)
        {
            FavoriteModel[] favs = await _favService.GetFavorites(userId, productTypeId);
            return favs;
        }

        [HttpPost("AddFavorite")]
        public async Task<FavoriteModel> AddFavorite([FromBody] FavoriteModel model)
        {
            int id = await _favService.AddFavorite(model);
            if (id == 0)
                throw new HexaDomainException("Apply favorite failed.");
            model.Id = id;
            return model;
        }

        [HttpPut("RenameFavorite")]
        public async Task<IActionResult> RenameFavorite(int id, string name)
        {
            int result = await _favService.RenameFavorite(id, name);
            if (result == 0)
                throw new HexaDomainException("Rename favorite failed.");
            return Ok("Name was updated.");
        }

        [HttpDelete("DeleteFavorite/{id}")]
        public async Task<int> DeleteFavorite([FromRoute] int id)
        {
            int result = await _favService.DeleteFavorite(id);
            if (result == 0)
                throw new HexaDomainException("Delete favorite failed.");
            return id;
        }
    }
}
