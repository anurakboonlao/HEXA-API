using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IUserRepository : IEntityBaseRepository<TblUser, HexaDBContext>
    {
        Task<UserModel> GetUserWithRole(string username);
        Task<List<UserModel>> GetUsersWithRole();
        Task<bool> IsUsernameExist(string username);
        Task<UserModel> GetUserWithRoleById(int userId);

        Task<UserModel> LoginUser(string username,string password);

        Task<List<UserModel>> GetAdminUsersWithRole();
    }
}
