using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.RejectNote;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IRejectNoteService
    {
        public Task<RejectNoteModel> CreateRejectNoteAsync(int userId, AddRejectNoteModel model, bool isAdmin);
    }
}
