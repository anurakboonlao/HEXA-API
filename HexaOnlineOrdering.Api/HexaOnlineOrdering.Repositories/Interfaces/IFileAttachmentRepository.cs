using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface IFileAttachmentRepository : IEntityBaseRepository<TblCaseAttachedFile, HexaDBContext>
    {
        Task<List<DisplayAttachFile>> GetAttachFileListByCaseIdAsync(int caseId);
        Task<string> RemoveAttachFileByFileIdAsync(int fileId);

        Task<bool> UploadAttachFilesByCaseIdAsync(int caseId, string filePath, string fileName, int fileTypeId, int? casePresentationHistoryId);
    }
}
