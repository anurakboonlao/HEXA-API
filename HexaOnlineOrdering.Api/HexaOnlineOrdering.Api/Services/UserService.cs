using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Extensions;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.Interfaces;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IUserRoleRepository _userRoleRepo;
        private readonly IProductTypeRepository _productTypeRepo;

        public UserService(IUserRepository userRepo, IUserRoleRepository userRoleRepo, IProductTypeRepository productTypeRepo)
        {
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            _userRoleRepo = userRoleRepo ?? throw new ArgumentNullException(nameof(userRoleRepo));
            _productTypeRepo = productTypeRepo ?? throw new ArgumentNullException(nameof(productTypeRepo));
        }

        public async Task<List<UserModel>> GetAllUser()
        {
            var users = await _userRepo.GetUsersWithRole();
            return users;
        }

        public async Task<List<UserModel>> GetAdminUser()
        {
            var users = await _userRepo.GetAdminUsersWithRole();
            return users;
        }

        public async Task<UserModel> FindUser(string username)
        {
            var user = await _userRepo.GetUserWithRole(username);
            if (user != null)
                return user;

            return null;
        }

        public async Task DeleteUserBuId(int userId)
        {
            _userRepo.DeleteWithCondition(c => c.UserId == userId);
            await _userRepo.CommitAsync();
        }

        public async Task<UserModel> UpdateUser(UpdateUserModel user)
        {
            var updateUser = _userRepo.Get(c => c.UserId == user.UserId);
            updateUser.UserId = user.UserId;
            updateUser.Name = user.Name;
            updateUser.UserRoleId = user.UserRoleId;
            updateUser.Username = user.Username;

            if (!string.IsNullOrEmpty(user.Password))
                updateUser.Password = user.Password; // Password should be encrypted

            _userRepo.Update(updateUser);
            await _userRepo.CommitAsync();

            user.Password = null;
            user.ConfirmPassword = null;
            return user;
        }

        public async Task<UserModel> CreateUser(UpdateUserModel user)
        {
            TblUser updateUser = user.MapTo<TblUser>();
            await _userRepo.AddAsync(updateUser);
            await _userRepo.CommitAsync();
            user.UserId = updateUser.UserId;
            user.Password = null;
            user.ConfirmPassword = null;
            return user;
        }

        public async Task<UserModel> GetUserById(int userId)
        {
            var user = await _userRepo.GetUserWithRoleById(userId);
            return user;
        }

        public async Task<UserModel> LoginUser(string username, string password)
        {
            var user = await _userRepo.LoginUser(username, password);
            if (user != null)
                return user;

            return null;
        }

        public async Task<DisplayRolePermissionModel> AddNewRole(DisplayRolePermissionModel role)
        {
            if(role == null)
            {
                throw new HexaDomainException("Add new role error, Bad request null role");
            }

            // In case of already have this RoleName
            TblUserRole getUserRole = _userRoleRepo.Get(u => u.Name == role.Name);
            if ( getUserRole != null)
            {
                return null;
            }

            List<int> productTypeIdList = new List<int>();
            if (role.ProductTypeList != null)
            {
                productTypeIdList = role.ProductTypeList.Select(pt => pt.Id).ToList();
            }      

            List<TblProductType> tblProductTypeList = await _productTypeRepo.GetProductTypeByIdList(productTypeIdList);
            TblUserRole userRole = new TblUserRole();
            userRole.Name = role.Name;
            userRole.ProductType = tblProductTypeList;


            await _userRoleRepo.AddAsync(userRole);
            await _userRoleRepo.CommitAsync();

            DisplayRolePermissionModel displayRole = Repositories.CustomMapping.CustomMapTblToModel.MapDisplayRoles(userRole);
            return displayRole;       
        }


        public async Task<DisplayRolePermissionModel> UpdateRole( DisplayRolePermissionModel role)
        {
            //prevent from update dentist, clinic, admin, staff
            Role userrole = GetRoleEnumById(role.Id);
            if (userrole == Role.DENTIST && userrole == Role.CLINIC && userrole == Role.ADMIN && userrole == Role.STAFF)
            {
                throw new HexaDomainException("Update new role error, Bad request roleId");
            }
            // In case of already have this name
            TblUserRole getRole = _userRoleRepo.Get(u => u.Name == role.Name);
            if (getRole != null && getRole.Id != role.Id)
            {
                throw new HexaDomainException("Update new role error, Bad request RoleName");
            }
            
            List<int> productTypeIdList = new List<int>();

            if(role.ProductTypeList != null)
                productTypeIdList = role.ProductTypeList.Select(pt => pt.Id).ToList();
            List<TblProductType> tblProductTypeList = await _productTypeRepo.GetProductTypeByIdList(productTypeIdList);

            TblUserRole updateRole = await _userRoleRepo.GetRole(role.Id);
            if( updateRole == null)
            {
                throw new HexaDomainException("Update role Error, Bad request roleId");
            }
            updateRole.Name = role.Name;
            updateRole.ProductType = tblProductTypeList;

            _userRoleRepo.Update(updateRole);
            await _userRoleRepo.CommitAsync();

            DisplayRolePermissionModel displayRole = Repositories.CustomMapping.CustomMapTblToModel.MapDisplayRoles(updateRole);
            return displayRole;
        }


        public async Task<List<DisplayRolePermissionModel>> GetAllCustomRole()
        {
            List<DisplayRolePermissionModel> allRole = await _userRoleRepo.GetAllCustomRole();

            return allRole;
        }

        public async Task<List<DisplayRolePermissionModel>> GetAdminAndAllCustomRole()
        {
            List<DisplayRolePermissionModel> adminAndAllRole = await _userRoleRepo.GetAdminAndAllCustomRole();

            return adminAndAllRole;
        }

        public async Task<DisplayRolePermissionModel> GetRoleById(int roleId)
        {
            // prevent from get dentist, clinic, admin, staff
            Role role = GetRoleEnumById(roleId);
            if (role == Role.DENTIST && role == Role.CLINIC && role == Role.ADMIN && role == Role.STAFF)
            {
                throw new HexaDomainException("Get role by Id error, Bad request roleId");
            }
            TblUserRole  userRole = await _userRoleRepo.GetRole(roleId);
            DisplayRolePermissionModel displayRole = Repositories.CustomMapping.CustomMapTblToModel.MapDisplayRoles(userRole);
            return displayRole;
        }

        public async Task<int> DeleteRoleById(int roleId)
        {
            // prevent from delete dentist, clinic, admin, staff
            Role role = GetRoleEnumById(roleId);
            if(role == Role.DENTIST && role == Role.CLINIC && role == Role.ADMIN && role == Role.STAFF)
            {
                throw new HexaDomainException("Delete role error, Bad request roleId");
            }

            TblUserRole userRole = await _userRoleRepo.GetRole(roleId);
            if( userRole == null)
            {
                throw new HexaDomainException("Delete role error, Bad request roleId");
            }
            if(userRole.Users != null && userRole.Users.Count != 0)
            {
                throw new HexaDomainException("Delete role error, This role has been assigned to "+userRole.Users.Count.ToString()+" users");
            }
             _userRoleRepo.Delete(userRole);
            await _userRoleRepo.CommitAsync();

            return userRole.Id;
        }

        public Role GetRoleEnumById(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return Role.DENTIST;
                case 2:
                    return Role.CLINIC;
                case 3:
                    return Role.ADMIN;
                default:
                    return Role.STAFF;
            }
        }
    }
}
