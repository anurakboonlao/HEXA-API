using HexaOnlineOrdering.Models.Notification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Services.Interfaces
{
    public interface INotificationService
    {
        Task<List<DisplayNotification>> GetNotificationByIdAsync(int userId, int limit);
        Task<int> ReadNotificationAsync(int notiId);
        Task<int> CreateNotificationAsync(int userId, ReceiveNotificationModel notiModel);

        Task<int> GetTotalNotificationsAsync(int userId);
    }
}
