using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Enums;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories
{
    public class UserRepository : EntityBaseRepository<TblUser, HexaDBContext>, IUserRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public UserRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public  async Task<UserModel> GetUserWithRoleById(int userId)
        {
            var user = await _dbContext.Users.Include(c => c.UserRole)
                .ThenInclude(u => u.ProductType)
                .FirstOrDefaultAsync(c => c.UserId == userId);
            return _mapper.Map<TblUser, UserModel>(user);
        }

        public async Task<bool> IsUsernameExist(string username)
        {
            return await _dbContext.Users.CountAsync(c => c.Username == username) > 0;
        }

        public async Task<List<UserModel>> GetUsersWithRole()
        {
            var users = await _dbContext.Users.Include(c => c.UserRole).ToListAsync();
            return _mapper.Map<List<TblUser>, List<UserModel>>(users);
        }

        public async Task<List<UserModel>> GetAdminUsersWithRole()
        {
            var users = await _dbContext.Users.Include(c => c.UserRole)
                .Where(c => c.UserRoleId != (int)Role.DENTIST && c.UserRoleId != (int)Role.CLINIC)
                .ToListAsync();
            return _mapper.Map<List<TblUser>, List<UserModel>>(users);
        }

        public async Task<UserModel> GetUserWithRole(string username)
        {
            var user = await _dbContext.Users.Include(c => c.UserRole).FirstOrDefaultAsync(c => c.Username == username);
            return _mapper.Map<TblUser, UserModel>(user);
        }

        public async Task<UserModel> LoginUser(string username, string password)
        {
            var user = await _dbContext.Users.Include(c => c.UserRole).ThenInclude(u => u.ProductType)
                .FirstOrDefaultAsync(c => c.Username == username && c.Password == password);

            return _mapper.Map<TblUser, UserModel>(user);
        }
    }
}
