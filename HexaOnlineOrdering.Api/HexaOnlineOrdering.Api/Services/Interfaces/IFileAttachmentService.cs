using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IFileAttachmentService
    {
        // return attachment file model 
        Task<List<DisplayAttachFile>> GetAttachFileListByCaseIdAsync(int caseId, FileTypeEnum fileType, bool getAllHistory);
        // return files name (new name)
        Task<string> RemoveAttachFileByFileIdAsync(int fileId);

        // return true if upload is success
        Task<bool> UploadAttachFilesByCaseIdAsync(int caseId, string filePath, string fileName, int fileTypeId);

    }
}
