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
    public class CaseProductMaterialRepository : EntityBaseRepository<TblCaseProductMaterial, HexaDBContext>, ICaseProductMaterialRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public CaseProductMaterialRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
