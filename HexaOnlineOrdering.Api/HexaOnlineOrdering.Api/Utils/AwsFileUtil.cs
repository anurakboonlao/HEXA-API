using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Utils
{
    public class AwsFileUtil
    {
        private readonly IAWS3service _aws3service;
        public AwsFileUtil(IAWS3service aws3Service) 
        {
            _aws3service = aws3Service ?? throw new ArgumentNullException(nameof(aws3Service));

        }

        public async Task<List<DisplayAttachFile>> ConvertDisplayAttachFile(List<DisplayAttachFile>  displayAttachFiles)
        {
            List<DisplayAttachFile> finalAttachFiles = new List<DisplayAttachFile>();
            // change path file into real public path file
            foreach (DisplayAttachFile displayAttachFile in displayAttachFiles)
            {
                // TODO : use clone in proper way.
                DisplayAttachFile temp = new DisplayAttachFile();
                temp.CaseId = displayAttachFile.CaseId;
                temp.FileName = displayAttachFile.FileName;
                temp.UploadDate = displayAttachFile.UploadDate;
                temp.Id = displayAttachFile.Id;
                temp.FileTypeId = displayAttachFile.FileTypeId;
                temp.CasePresentationHistoryId = displayAttachFile.CasePresentationHistoryId;

                string realPath = _aws3service.GenerateAwsFileUrl(displayAttachFile.FilePath);
                long getSize = await _aws3service.GetFileSizeFromSpaceAsync(displayAttachFile.FilePath);
                temp.FilePath = realPath;
                temp.Size = getSize / 1000; // convert to KB
                finalAttachFiles.Add(temp);

            }
            return finalAttachFiles;
        }
    }
}
