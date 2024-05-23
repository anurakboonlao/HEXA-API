using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DashboardModel
    {
        public List<DateTime> DateList { get; set; }

        public List<DashboardCaseCount> CaseCounts { get; set; }
        public List<DashboardOrderCount> OrderCounts { get; set; }
        public List<DashboardOrder> OrderProduct { get; set; }
        public List<ProductGroupModel> AllGroupsOfProduct { get; set; }
    }
}
