using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models.Notification;
using HexaOnlineOrdering.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepo;
        public NotificationService(INotificationRepository notificationRepo)
        {
            _notificationRepo = notificationRepo ?? throw new ArgumentNullException(nameof(notificationRepo));
        }
        public async Task<List<DisplayNotification>> GetNotificationByIdAsync(int userId, int limit)
        {
            return await _notificationRepo.GetNotificationByIdAsync(userId, limit);
        }
        public async Task<int> ReadNotificationAsync(int notiId)
        {
            return await _notificationRepo.ReadNotificationAsync(notiId);
        }
        public async Task<int> CreateNotificationAsync(int userId, ReceiveNotificationModel notiModel)
        {
            return await _notificationRepo.CreateNotificationAsync(userId, notiModel);
        }
        public async Task<int> GetTotalNotificationsAsync(int userId)
        {
            return await _notificationRepo.GetTotalNotificationsAsync(userId);
        }
    }
}
