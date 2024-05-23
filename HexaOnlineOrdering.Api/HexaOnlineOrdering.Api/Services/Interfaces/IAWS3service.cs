using HexaOnlineOrdering.Models.AttachmentFile;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface IAWS3service
    {
        List<string> GetFileListFromSpacesBackupStorage();
        Task<List<FileNameObjectModel>> UploadFileToDOSpaceAsync(List<IFormFile> files, string subDir = "");
        Task<bool> RemoveFileFromDOSpaceAsync(string fileName);
        Task<long> GetFileSizeFromSpaceAsync(string fileName);
        string GenerateAwsFileUrl(string key, bool useRegion = true);
        string GenerateAwsRegularFileUrl(string path, bool useRegion = true);
    }
}
