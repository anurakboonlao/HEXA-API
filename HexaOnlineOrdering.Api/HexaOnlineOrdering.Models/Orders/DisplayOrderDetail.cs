using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DisplayOrderDetail
    {
        public List<CaseItemModel> CaseOrderLists { get; set; }

        public OrderDetailModel OrderDetail { get; set; }
    }
}
