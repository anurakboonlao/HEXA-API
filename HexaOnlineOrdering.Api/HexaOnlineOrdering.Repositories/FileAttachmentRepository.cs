using HexaOnlineOrdering.Models;
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
    public class FileAttachmentRepository : EntityBaseRepository<TblCaseAttachedFile, HexaDBContext>, IFileAttachmentRepository
    {
        private readonly HexaDBContext _dbContext;
        public FileAttachmentRepository(HexaDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }

        public async Task<List<DisplayAttachFile>> GetAttachFileListByCaseIdAsync(int caseId)
        {
            List<DisplayAttachFile> attachFiles = new List<DisplayAttachFile>();

            List<TblCaseAttachedFile> tblAttachFile = await _dbContext.CaseAttachedFiles.Where(c => c.CaseId == caseId).ToListAsync();

            foreach (TblCaseAttachedFile item in tblAttachFile)
            {
                DisplayAttachFile attachFile = new DisplayAttachFile();
                attachFile.CaseId = item.CaseId;
                attachFile.FileName = item.FileName;
                attachFile.UploadDate = item.UploadedDate;
                attachFile.FilePath = item.FilePath;
                attachFile.Id = item.Id;
                attachFile.FileTypeId = item.FileTypeId;
                attachFile.CasePresentationHistoryId = item.CasePresentationHistoryId;

                attachFiles.Add(attachFile);
            }

            return attachFiles;
        }
        public async Task<string> RemoveAttachFileByFileIdAsync(int fileId)
        {
            string result = String.Empty;
            if (fileId < 0)
            {
                return result;
            }

            TblCaseAttachedFile attachFile = await _dbContext.CaseAttachedFiles.Where(c => c.Id == fileId).SingleOrDefaultAsync();
            if (attachFile == null)
            {
                return result;
            }

            result = attachFile.FilePath;
            _dbContext.Remove(attachFile);
            _dbContext.SaveChanges();

            return result;
        }

        public async Task<bool> UploadAttachFilesByCaseIdAsync(int caseId, string filePath, string fileName, int fileTypeId, int? casePresentationHistoryId)
        {
            TblCaseAttachedFile saveAttachFile = new TblCaseAttachedFile();
            saveAttachFile.CaseId = caseId;
            saveAttachFile.FileName = fileName;
            saveAttachFile.FilePath = filePath;
            saveAttachFile.UploadedDate = DateTime.Now;
            saveAttachFile.FileTypeId = fileTypeId;
            saveAttachFile.CasePresentationHistoryId = casePresentationHistoryId;

            await AddAsync(saveAttachFile);
            int result = await CommitAsync();

            return Convert.ToBoolean(result); 
        }

    }
}
