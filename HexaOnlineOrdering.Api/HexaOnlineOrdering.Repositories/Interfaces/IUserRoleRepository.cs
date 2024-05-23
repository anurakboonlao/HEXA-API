using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IUserRoleRepository : IEntityBaseRepository<TblUserRole, HexaDBContext>
    {
        Task<List<DisplayRolePermissionModel>> GetAllCustomRole();
        Task<List<DisplayRolePermissionModel>> GetAdminAndAllCustomRole();
        Task<TblUserRole> GetRole(int roleId);
        
    }
}
