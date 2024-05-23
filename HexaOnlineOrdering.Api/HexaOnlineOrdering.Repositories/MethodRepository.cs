using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories
{
    public class MethodRepository : EntityBaseRepository<TblMethod, HexaDBContext>, IMethodRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public MethodRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<MethodModel>> GetMethodByTypeId(int typeId)
        {
            List<TblMethod> methods = await _dbContext.Methods.Where(m => m.ProductTypeId == typeId).ToListAsync();
            return _mapper.Map<List<TblMethod>, List<MethodModel>>(methods);
        }
    }
}
