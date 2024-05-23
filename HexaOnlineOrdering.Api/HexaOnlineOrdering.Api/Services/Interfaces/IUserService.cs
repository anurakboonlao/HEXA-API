using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Enums;
using HexaOnlineOrdering.Repositories.DataModels;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAllUser();
        Task<UserModel> FindUser(string username);
        Task DeleteUserBuId(int userId);
        Task<UserModel> UpdateUser(UpdateUserModel user);
        Task<UserModel> CreateUser(UpdateUserModel user);
        Task<UserModel> GetUserById(int userId);

        Task<UserModel> LoginUser(string username,string password);

        Task<List<UserModel>> GetAdminUser();

        Task<DisplayRolePermissionModel> AddNewRole(DisplayRolePermissionModel role);
        Task<DisplayRolePermissionModel> UpdateRole(DisplayRolePermissionModel rolePermission);
        Task<List<DisplayRolePermissionModel>> GetAllCustomRole();
        Task<List<DisplayRolePermissionModel>> GetAdminAndAllCustomRole();
        Task<DisplayRolePermissionModel> GetRoleById(int roleId);
        Task<int> DeleteRoleById(int roleId);
        public Role GetRoleEnumById(int roleId);

    }
}
