using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Enums;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories
{
    public class UserRoleRepository : EntityBaseRepository<TblUserRole, HexaDBContext>, IUserRoleRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public UserRoleRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<DisplayRolePermissionModel>> GetAllCustomRole()
        {
            List<int> forbiddenRoleId = getAllForbiddenRoleId();
            var userRolePermission = await _dbContext.UserRoles
                                    .Include(u => u.ProductType)
                                    .Include(u => u.Users)
                                    .Where(u => !forbiddenRoleId.Contains(u.Id))
                                    .ToListAsync();

            List<DisplayRolePermissionModel> displayRoleList = new List<DisplayRolePermissionModel>();
            foreach (TblUserRole userRole in userRolePermission)
            {
                DisplayRolePermissionModel displayUserRole = CustomMapping.CustomMapTblToModel.MapDisplayRoles(userRole);
                displayRoleList.Add(displayUserRole);
            }

            return displayRoleList;
        }

        public async Task<List<DisplayRolePermissionModel>> GetAdminAndAllCustomRole()
        {
            List<int> forbiddenRoleId = getAllForbiddenRoleIdExceptAdminRole();
            var userRolePermission = await _dbContext.UserRoles
                                    .Include(u => u.ProductType)
                                    .Include(u => u.Users)
                                    .Where(u => !forbiddenRoleId.Contains(u.Id) )
                                    .ToListAsync();

            List<DisplayRolePermissionModel> displayRoleList = new List<DisplayRolePermissionModel>();
            foreach (TblUserRole userRole in userRolePermission)
            {
                DisplayRolePermissionModel displayUserRole = CustomMapping.CustomMapTblToModel.MapDisplayRoles(userRole);
                displayRoleList.Add(displayUserRole);
            }

            return displayRoleList;
        }

        public async Task<TblUserRole> GetRole(int roleId)
        {
            TblUserRole userRolePermission = await  _dbContext.UserRoles
                                                        .Include(u => u.ProductType)
                                                        .Include(u => u.Users)
                                                        .Where(u => u.Id == roleId)
                                                        .SingleOrDefaultAsync();

            return userRolePermission;
        }

        private List<int> getAllForbiddenRoleId()
        {
            return  Enum.GetValues(typeof(Role)).Cast<int>().ToList();
        }

        private List<int> getAllForbiddenRoleIdExceptAdminRole()
        {
            List<int> forbiddenRoleId = Enum.GetValues(typeof(Role)).Cast<int>().ToList();
            forbiddenRoleId.Remove( (int)Role.ADMIN );
            return forbiddenRoleId;
        }
    }
}
