using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DashboardOrder
    {
        public int OrderId { get; set; }
        public int OrderStatusId { get; set; }

        public List<DashboardOrderProduct> Products { get; set; }
    }
}
