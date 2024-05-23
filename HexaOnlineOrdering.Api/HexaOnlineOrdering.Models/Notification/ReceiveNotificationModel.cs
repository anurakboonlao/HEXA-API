using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.Notification
{
    public class ReceiveNotificationModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public int userId { get; set; }
    }
}
