using HexaOnlineOrdering.Models.Notification;
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
    public class NotificationRepository : EntityBaseRepository<TblNotification, HexaDBContext>, INotificationRepository
    {
        private readonly HexaDBContext _dbContext;
        public NotificationRepository(HexaDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }
        public async Task<List<DisplayNotification>> GetNotificationByIdAsync(int userId, int limit)
        {
            List<DisplayNotification> displayNotifications = new List<DisplayNotification>();
            if (userId < 0)
            {
                return displayNotifications;
            }

            List<TblNotification> tblnotifications = await _dbContext.Notifications.Where(noti => noti.UserId == userId)
                .OrderByDescending(noti => noti.LastUpdateDate)
                .Take(limit)
                .ToListAsync();

            if (tblnotifications == null)
            {
                return displayNotifications;
            }

            foreach(TblNotification notis in tblnotifications)
            {
                DisplayNotification displayNoti = new DisplayNotification();
                displayNoti.Id = notis.Id;
                displayNoti.LastUpdateDate = notis.LastUpdateDate;
                displayNoti.Message = notis.Message;
                displayNoti.Read = notis.Read;
                displayNoti.Title = notis.Title;
                displayNoti.userId = notis.UserId;

                displayNotifications.Add(displayNoti);
            }

            return displayNotifications;
        }
        public async Task<int> ReadNotificationAsync(int notiId)
        {
            TblNotification tblnotifications = await _dbContext.Notifications.Where(noti => noti.Id == notiId).SingleOrDefaultAsync();
            tblnotifications.Read = true;

            if (tblnotifications != null)
            {
                _dbContext.Update(tblnotifications);
            }
            else
            {
                return -1;
            }
            
            int result = await _dbContext.SaveChangesAsync();

            if (result <= 0) 
            { 
                return -1; 
            }

            return notiId;

        }
        public async Task<int> CreateNotificationAsync(int userId, ReceiveNotificationModel notiModel)
        {

            if (notiModel != null)
            {
                TblNotification tblNotification = new TblNotification();
                tblNotification.CreatedDate = DateTime.Now;
                tblNotification.LastUpdateDate = DateTime.Now;
                tblNotification.Read = false;
                tblNotification.Title = notiModel.Title;
                tblNotification.Message = notiModel.Message;
                tblNotification.UserId = userId;

                await AddAsync(tblNotification);
                await CommitAsync();

                return tblNotification.Id;
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> GetTotalNotificationsAsync(int userId)
        {
            if (userId < 0)
            {
                return 0;
            }

            List<TblNotification> tblnotifications = await _dbContext.Notifications.Where(noti => noti.UserId == userId).ToListAsync();
            
            if(tblnotifications == null)
            {
                return 0;
            }
            
            return tblnotifications.Count;
        }
    }
}
