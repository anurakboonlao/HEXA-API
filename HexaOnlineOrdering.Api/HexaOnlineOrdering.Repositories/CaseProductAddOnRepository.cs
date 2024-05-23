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
    public class CaseProductAddOnRepository : EntityBaseRepository<TblCaseProductAddOn, HexaDBContext>, ICaseProductAddOnRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public CaseProductAddOnRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
