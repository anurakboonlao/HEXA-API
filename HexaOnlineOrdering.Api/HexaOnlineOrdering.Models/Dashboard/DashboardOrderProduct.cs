using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DashboardOrderProduct
    {
        public int ProductTypeId { get; set; }
        public int ProductId { get; set; }
        public int ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
    }
}
