using HexaOnlineOrdering.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Repositories.Interfaces;
using System.Diagnostics;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Api.Extensions;
using AutoMapper;
using HexaOnlineOrdering.Models.Notification;
using HexaOnlineOrdering.Models.Orders;
using HexaOnlineOrdering.Models.Marketing;
using System.Net.Http;
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
using HexaOnlineOrdering.Models.RejectNote;

namespace HexaOnlineOrdering.Api.Services
{
    public class RejectNoteService : IRejectNoteService
    {
        private readonly IRejectNoteRepository _rejectNoteRepository;
        private readonly ILogger<UserContactService> _logger;
        private readonly IOrderOverviewRepository _orderRepository;

        public RejectNoteService(IRejectNoteRepository rejectNoteRepository, ILogger<UserContactService> logger, IOrderOverviewRepository orderRepository)
        {
            _rejectNoteRepository = rejectNoteRepository ?? throw new ArgumentNullException(nameof(rejectNoteRepository));
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<RejectNoteModel> CreateRejectNoteAsync(int userId, AddRejectNoteModel model, bool isAdmin)
        {
            _logger.LogInformation("Add RejectNote in Service");
            int orderId = model.OrderId;
            if (orderId <= 0)
            {
                TblOrder order = await _orderRepository.GetAsync(c => c.CaseId == model.CaseId);
                orderId = order.Id;
            }

            RejectNoteModel rejectNoteModel = new RejectNoteModel();
            rejectNoteModel.Note = model.Note;
            rejectNoteModel.OrderId = orderId;
            rejectNoteModel.RejectDate = DateTime.Now;
            rejectNoteModel.RejectUserId = userId;
            rejectNoteModel.IsAdmin = isAdmin;
            int resultId = await _rejectNoteRepository.CreateRejectNoteAsync(rejectNoteModel);
            if(resultId <= 0)
            {
                throw new HexaDomainException("Cannot add RejectNote in Service");
            }
            rejectNoteModel.Id = resultId;
            return rejectNoteModel;

        }
    }
}
