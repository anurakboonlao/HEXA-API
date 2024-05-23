using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DashboardOrderCount
    {
        public DateTime Date { get; set; }
        public int TotalCount { 
            get
            {
                return PendingCount + AcceptedCount + DeliveredCount + RejectedCount;
            } 
        }
        public int PendingCount { get; set; }
        public int AcceptedCount { get; set; }
        public int DeliveredCount { get; set; }
        public int RejectedCount { get; set; }

    }
}
