
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IRejectNoteRepository : IEntityBaseRepository<TblRejectNote, HexaDBContext>
    {
        public Task<int> CreateRejectNoteAsync( RejectNoteModel model);
    }
}
