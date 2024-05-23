using HexaOnlineOrdering.Models.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.Interfaces
{
    public interface INotificationRepository
    {
        Task<List<DisplayNotification>> GetNotificationByIdAsync(int userId, int limit);
        Task<int> ReadNotificationAsync(int notiId);
        Task<int> CreateNotificationAsync(int userId, ReceiveNotificationModel notiModel);
        Task<int> GetTotalNotificationsAsync(int userId);
    }
}
