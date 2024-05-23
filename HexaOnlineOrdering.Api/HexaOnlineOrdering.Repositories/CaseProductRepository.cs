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
    public class CaseProductRepository : EntityBaseRepository<TblCaseProduct, HexaDBContext>, ICaseProductRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public CaseProductRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<TblCaseProduct> GetCaseProductByCaseId(int caseId)
        {
            TblCaseProduct caseProduct = await _dbContext.CaseProducts.Include(i => i.Product).Where(i => i.CaseId == caseId).FirstOrDefaultAsync();
            return caseProduct;
        }

        public async Task<CaseProductModel> UpdateProductByCaseId(int caseId, int productId)
        {
            TblCaseProduct caseProduct = await _dbContext.CaseProducts.Where(i => i.CaseId == caseId).FirstOrDefaultAsync();
            
            caseProduct.ProductId = productId;

            _dbContext.Update(caseProduct);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<TblCaseProduct, CaseProductModel>(caseProduct);
        }
    }
}
