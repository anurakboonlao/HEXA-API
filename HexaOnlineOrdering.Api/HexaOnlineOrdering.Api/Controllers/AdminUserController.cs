using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HexaOnlineOrdering.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,Staff")]
    public class AdminUserController : BaseController
    {
        private readonly IUserService _userService;

        public AdminUserController(IHttpContextAccessor httpContextAccessor, IUserService userService) : base(httpContextAccessor)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }


        [HttpGet("GetAll")]
        public async Task<List<UserModel>> GetAdminUsers()
        {
            return await _userService.GetAllUser();
        }

        [HttpGet("GetAdminUser")]
        public async Task<List<UserModel>> GetAdminUser()
        {
            return await _userService.GetAdminUser();
        }

        [HttpPut("UpdateUser")]
        public async Task<UserModel> UpdateUser([FromBody]UpdateUserModel user)
        {
            if (!string.IsNullOrEmpty(user.Password) && user.Password != user.ConfirmPassword)
                throw new HexaDomainException("Password is not correct.");


            // Check user is exist
            var existingUser = await _userService.GetUserById(user.UserId);
            if(existingUser == null)
                throw new HexaDomainException("User id doesn't exist.");

            // Check username must not be duplicate
            existingUser = await _userService.FindUser(user.Username);
            if (existingUser != null && existingUser.UserId != user.UserId)
                throw new HexaDomainException("Username already exist.");
         
            return await _userService.UpdateUser(user);
        }

        [HttpPost("AddUser")]
        public async Task<UserModel> AddUser([FromBody] UpdateUserModel user)
        {
            if (user.Password != user.ConfirmPassword || string.IsNullOrEmpty(user.Password))
                throw new HexaDomainException("Password is not correct.");

            // Check username must not be duplicate
            var existingUser = await _userService.FindUser(user.Username);
            if (existingUser != null && existingUser.UserId != user.UserId)
                throw new HexaDomainException("Username already exist.");

            return await _userService.CreateUser(user);
        }

        [HttpDelete("Delete/{userId}")]
        public async Task<int> DeleteUser([FromRoute] int userId)
        {
            // Check user is exist
            var existingUser = await _userService.GetUserById(userId);
            if (existingUser == null)
                throw new HexaDomainException("User id doesn't exist.");

            await _userService.DeleteUserBuId(userId);
            return userId;
        }

        [HttpPost("AddNewRole")]
        public async Task<DisplayRolePermissionModel> AddNewRole([FromBody] DisplayRolePermissionModel displayRoleRequest)
        {
            var userRole = await _userService.AddNewRole(displayRoleRequest);
            if (userRole == null)
            {
                throw new HexaDomainException("Add new role error, Bad request RoleName");
            }

            return userRole;
        }

        [HttpGet("GetAllCustomRole")]
        public async Task<List<DisplayRolePermissionModel>> GetAllRole()
        {
            List<DisplayRolePermissionModel> rolePermission = await _userService.GetAllCustomRole();
            return  rolePermission ;
        }

        [HttpGet("GetRoleById/{roleId}")]
        public async Task<DisplayRolePermissionModel> GetRoleById([FromRoute] int roleId)
        {
            DisplayRolePermissionModel rolePermission = await _userService.GetRoleById(roleId);
            return rolePermission;
        }

        [HttpPut("UpdateRole")]
        public async Task<DisplayRolePermissionModel> UpdateRole([FromBody] DisplayRolePermissionModel displayRolePermission)
        {
            var userRole = await _userService.UpdateRole(displayRolePermission);
            return userRole;
        }

        [HttpDelete("DeleteRoleById/{roleId}")]
        public async Task<int> DeleteRole([FromRoute] int roleId)
        {
            var result = await _userService.DeleteRoleById(roleId);
            return result;
        }

        [HttpGet("GetAdminAndAllCustomRole")]
        public async Task<List<DisplayRolePermissionModel>> GetAdminAndAllCustomRole()
        {
            var adminAndAllCustomRole = await _userService.GetAdminAndAllCustomRole();
            return adminAndAllCustomRole;
        }

    }
}
