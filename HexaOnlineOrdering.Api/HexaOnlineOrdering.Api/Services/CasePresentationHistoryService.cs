using System.Text;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using HexaOnlineOrdering.Api.Options;
using Microsoft.Extensions.Options;
using HexaOnlineOrdering.Api.Utils;
using DinkToPdf.Contracts;
using HexaOnlineOrdering.Models.Enums;
using HexaOnlineOrdering.Models.CasePresentationHistory;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Repositories.Interfaces;
using System;
using System.Threading.Tasks;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Api.Exceptions;
using System.Collections.Generic;
using HexaOnlineOrdering.Models;
using System.Linq;

namespace HexaOnlineOrdering.Api.Services
{
    public class CasePresentationHistoryService : ICasePresentationHistoryService
    {
        private readonly ICasePresentationHistoryRepository _casePresentationHistoryRepository;
        private readonly ILogger<UserContactService> _logger;
        private readonly IOrderOverviewRepository _orderRepository;
        private readonly IAWS3service _aws3service;
        private readonly IFileAttachmentService _fileAttachmentService;

        public CasePresentationHistoryService(ICasePresentationHistoryRepository casePresentationHistoryRepository, IAWS3service aws3Service, ILogger<UserContactService> logger, IOrderOverviewRepository orderRepository, IFileAttachmentService fileAttachmentService)
        {
            _casePresentationHistoryRepository = casePresentationHistoryRepository ?? throw new ArgumentNullException(nameof(casePresentationHistoryRepository));
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _aws3service = aws3Service ?? throw new ArgumentNullException(nameof(aws3Service));
            _fileAttachmentService = fileAttachmentService ?? throw new ArgumentNullException(nameof(fileAttachmentService));
        }

        public async Task<CasePresentationHistoryModel> CreateCasePresentationHistoryAsync(AddCasePresentationHistoryModel model)
        {
            _logger.LogInformation("Add CasePresentationHistory in Service");
            int caseId = model.CaseId;
            if (caseId <= 0)
            {
                TblOrder order = await _orderRepository.GetAsync(c => c.Id == model.OrderId);
                caseId = order.CaseId;
            }

            CasePresentationHistoryModel newModel = new CasePresentationHistoryModel();
            newModel.Note = model.Note;
            newModel.CaseId = caseId;
            newModel.RequestEditDate = DateTime.Now;
            int resultId = await _casePresentationHistoryRepository.CreateCasePresentationHistoryAsync(newModel);
            if (resultId <= 0)
            {
                throw new HexaDomainException("Cannot add RejectNote in Service");
            }
            newModel.Id = resultId;
            return newModel;
        }

        public async Task<List<CasePresentationHistoryModel>> GetCasePresentationHistoryAsync(int caseId, int orderId)
        {
            _logger.LogInformation("Get CasePresentationHistory in Service");

            if (caseId <= 0)
            {
                TblOrder order = await _orderRepository.GetAsync(c => c.Id == orderId);
                caseId = order.CaseId;
            }

            List<CasePresentationHistoryModel> result = await _casePresentationHistoryRepository.GetCasePresentationHistoryByCaseIdAsync(caseId);

            // TODO : If need add first send case presentation
            AwsFileUtil util = new AwsFileUtil(_aws3service);
            foreach (CasePresentationHistoryModel item in result)
            {
                // change path file into real public path file
                List<DisplayAttachFile> finalAttachFiles = await util.ConvertDisplayAttachFile(item.RequestCaseAttachedFiles);
                item.RequestCaseAttachedFiles = finalAttachFiles;
            }

            if (result == null)
                return new List<CasePresentationHistoryModel>();
            return result;
        }
    }
}
