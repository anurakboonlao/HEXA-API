using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Api.Utils;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.AttachmentFile;
using HexaOnlineOrdering.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Dentist,Clinic,Admin,Staff")]
    public class AttachmentController : BaseController
    {
        private readonly IAWS3service _aws3service;
        private readonly IFileAttachmentService _fileAttachmentService;
        private readonly IOrdersService _ordersService;
        public AttachmentController(IOrdersService ordersService, IHttpContextAccessor httpContextAccessor, IAWS3service aws3Service, IFileAttachmentService fileAttachmentService) : base(httpContextAccessor)
        {
            _aws3service = aws3Service ?? throw new ArgumentNullException(nameof(aws3Service));
            _fileAttachmentService = fileAttachmentService ?? throw new ArgumentNullException(nameof(fileAttachmentService));
            _ordersService = ordersService ?? throw new ArgumentNullException(nameof(ordersService));
        }

        [HttpPost("UploadFiles/{caseId}")]
        public async Task<List<DisplayAttachFile>> UploadFileToCaseById([FromRoute] int caseId, [FromForm] List<IFormFile> files,[FromForm] int fileTypeId)
        {
            if(caseId < 1)
            {
                // case Id is not valid
                throw new HexaDomainException("case Id is not valid.");
            }

            List<FileNameObjectModel> resultFileNameObject = await _aws3service.UploadFileToDOSpaceAsync(files, "Case");
            if (resultFileNameObject.Count < 1)
            {
                // upload error 
                throw new HexaDomainException("Can not upload file.");
            }

            // Update database after finish uploading
            foreach (FileNameObjectModel fileNameObject in resultFileNameObject)
            {
                await _fileAttachmentService.UploadAttachFilesByCaseIdAsync(caseId, fileNameObject.FilePath, fileNameObject.FileName, fileTypeId);
            }

            List<DisplayAttachFile> attachFiles =  await GetAttachmentFileByCaseId(caseId, FileTypeEnum.All, false);

            return attachFiles;
        }

        [HttpGet("GetFiles/{caseId}")]
        public async Task<List<DisplayAttachFile>> GetAttachmentFileByCaseId([FromRoute] int caseId,[FromQuery] FileTypeEnum fileType, [FromQuery] bool getAllHistory)
        {
            List<DisplayAttachFile> displayAttachFiles = await _fileAttachmentService.GetAttachFileListByCaseIdAsync(caseId, fileType, getAllHistory);

            if (displayAttachFiles == null)
            {
                throw new HexaDomainException("Get attachment file error.");
            }
            AwsFileUtil util = new AwsFileUtil(_aws3service);

            // change path file into real public path file
            List<DisplayAttachFile> finalAttachFiles = await util.ConvertDisplayAttachFile(displayAttachFiles);      
            return finalAttachFiles;
        }

        [HttpGet("GetFilesByOrderId/{orderId}")]
        public async Task<List<DisplayAttachFile>> GetAttachmentFileByOrderId([FromRoute] int orderId)
        {
            OrderModel order = _ordersService.GetOrder(orderId);
            if(order == null)
            {
                throw new HexaDomainException("Oder not found");
            }

            return await GetAttachmentFileByCaseId(order.CaseId, FileTypeEnum.All, false);

        }

        [HttpDelete("DeleteFile/{fileId}")]
        public async Task<int> DeleteFileByFileId([FromRoute] int fileId)
        {
            // return file name
            string filePath = await _fileAttachmentService.RemoveAttachFileByFileIdAsync(fileId);

            bool success = await _aws3service.RemoveFileFromDOSpaceAsync(filePath);
            return fileId;
        }
    }

}
