using HexaOnlineOrdering.Models;
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
    public class RejectNoteRepository : EntityBaseRepository<TblRejectNote, HexaDBContext>, IRejectNoteRepository
    {
        private readonly HexaDBContext _dbContext;

        public RejectNoteRepository(HexaDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }

        public async Task<int> CreateRejectNoteAsync( RejectNoteModel model)
        {
            if (model != null)
            {
                TblRejectNote databaseModel = new TblRejectNote();
                databaseModel.Note = model.Note;
                databaseModel.OrderId = model.OrderId;
                databaseModel.RejectDate = model.RejectDate;
                databaseModel.RejectUserId = model.RejectUserId;
                databaseModel.IsAdmin = model.IsAdmin;

                await AddAsync(databaseModel);
                await CommitAsync();

                return databaseModel.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
