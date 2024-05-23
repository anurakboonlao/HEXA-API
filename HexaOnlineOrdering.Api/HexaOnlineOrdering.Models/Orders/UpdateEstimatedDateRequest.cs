using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class UpdateEstimatedDateRequest
    {
        public int OrderId { get; set; }
        public DateTime EstimatedDate { get; set; }
        public string NotificationText { get; set; }
    }
}
