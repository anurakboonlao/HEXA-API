using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.CasePresentationHistory;
using HexaOnlineOrdering.Models.Enums;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories;
using HexaOnlineOrdering.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services
{
    public class FileAttachmentService : IFileAttachmentService
    {
        private readonly IFileAttachmentRepository _fileAttachment;
        private readonly IOrderOverviewRepository _orderRepo;
        private readonly ICasePresentationHistoryRepository _casePresentationHistorRepo;
        private int CASE_PRESENTATION_FILE = 4;
        public FileAttachmentService(IFileAttachmentRepository fileAttachment, IOrderOverviewRepository orderRepo, ICasePresentationHistoryRepository casePresentationHistorRepo)
        {
            _fileAttachment = fileAttachment ?? throw new ArgumentNullException(nameof(fileAttachment));
            _orderRepo = orderRepo ?? throw new ArgumentNullException(nameof(orderRepo));
            _casePresentationHistorRepo = casePresentationHistorRepo ?? throw new ArgumentNullException(nameof(casePresentationHistorRepo));
        }

        public async Task<List<DisplayAttachFile>> GetAttachFileListByCaseIdAsync(int caseId, FileTypeEnum fileType, bool getAllHistory)
        {
            List<DisplayAttachFile> displayAttachFiles = await _fileAttachment.GetAttachFileListByCaseIdAsync(caseId);
            
            if (fileType != FileTypeEnum.All)
                displayAttachFiles = displayAttachFiles.Where(f => f.FileTypeId == (int)fileType).ToList();

            if (!getAllHistory)
            {
                DisplayAttachFile top = displayAttachFiles.OrderByDescending(o => o.CasePresentationHistoryId).FirstOrDefault();
                if(top != null && top.CasePresentationHistoryId.HasValue)
                {
                    // Filter out old case presentation files
                    int latestEdit = top.CasePresentationHistoryId.Value;
                    displayAttachFiles = displayAttachFiles
                        .Where(f => f.FileTypeId != (int)FileTypeEnum.CASE_PRESENTATION ||
                        (f.FileTypeId == (int)FileTypeEnum.CASE_PRESENTATION && f.CasePresentationHistoryId == latestEdit))
                        .ToList();
                }
            }

            return displayAttachFiles;
        }

        public async Task<string> RemoveAttachFileByFileIdAsync(int fileId)
        {
            return await _fileAttachment.RemoveAttachFileByFileIdAsync(fileId);
        }

        public async Task<bool> UploadAttachFilesByCaseIdAsync(int caseId, string filePath, string fileName, int fileTypeId)
        {
            int? casePresentationHistorId = null;
           
            if (fileTypeId == CASE_PRESENTATION_FILE)
            {
                //Get last Case Presentation History
                CasePresentationHistoryModel cph = await _casePresentationHistorRepo.GetLastCasePresentationHistoryAsync(caseId);
                if(cph != null)
                {
                    casePresentationHistorId = cph.Id;
                } else
                {
                    CasePresentationHistoryModel newModel = new CasePresentationHistoryModel();
                    newModel.Note = "First presentation file.";
                    newModel.CaseId = caseId;
                    newModel.RequestEditDate = DateTime.Now;
                    int resultId = await _casePresentationHistorRepo.CreateCasePresentationHistoryAsync(newModel);
                    if (resultId <= 0)
                    {
                        throw new HexaDomainException("Cant add CasePresentationHistory in Service.");
                    }

                    casePresentationHistorId = resultId;
                }
            }

            return await _fileAttachment.UploadAttachFilesByCaseIdAsync(caseId, filePath, fileName, fileTypeId, casePresentationHistorId);
        }
    }
}
