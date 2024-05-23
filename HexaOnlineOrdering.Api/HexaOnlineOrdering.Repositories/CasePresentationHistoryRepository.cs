using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.CasePresentationHistory;
using HexaOnlineOrdering.Models.Notification;
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
    public class CasePresentationHistoryRepository: EntityBaseRepository<TblCasePresentationHistory, HexaDBContext>, ICasePresentationHistoryRepository
    {
        private readonly HexaDBContext _dbContext;
        private readonly IMapper _mapper;

        public CasePresentationHistoryRepository(HexaDBContext dbContext, IMapper mapper) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> CreateCasePresentationHistoryAsync(CasePresentationHistoryModel model)
        {
            if (model != null)
            {
                TblCasePresentationHistory databaseModel = new TblCasePresentationHistory();
                databaseModel.Note = model.Note;
                databaseModel.CaseId = model.CaseId;
                databaseModel.RequestEditDate = model.RequestEditDate;

                await AddAsync(databaseModel);
                await CommitAsync();

                return databaseModel.Id;
            }
            else
            {
                return 0;
            }
        }

        public async Task<CasePresentationHistoryModel> GetLastCasePresentationHistoryAsync(int caseId)
        {
           TblCasePresentationHistory tblModel = await _dbContext.CasePresentationHistory
                .Where(c => c.CaseId == caseId)
                .OrderByDescending(o => o.RequestEditDate)
                .FirstOrDefaultAsync();

            if(tblModel != null)
            {
                return _mapper.Map<TblCasePresentationHistory, CasePresentationHistoryModel>(tblModel);
            }

            return null;
        }

        public async Task<List<CasePresentationHistoryModel>> GetCasePresentationHistoryByCaseIdAsync(int caseId)
        {
            List<TblCasePresentationHistory> tblModels = await _dbContext.CasePresentationHistory
                 .Where(c => c.CaseId == caseId)
                 .Include(h => h.RequestCaseAttachedFiles)
                 .OrderBy(o => o.RequestEditDate)
                 .ToListAsync();

            if (tblModels != null)
            {
                return _mapper.Map<List<TblCasePresentationHistory>, List<CasePresentationHistoryModel>>(tblModels);
            }

            return null;
        }
    }
}
