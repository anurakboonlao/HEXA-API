using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.Notification
{
    public class DisplayNotification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Read { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int userId { get; set; }
    }

    public class DisplayNotificationWithTotal
    {
        public List<DisplayNotification> Notification { get; set; }
        public int TotalNotification {get; set;}
    }
}
