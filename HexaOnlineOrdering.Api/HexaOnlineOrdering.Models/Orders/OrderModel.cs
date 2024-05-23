using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime  OrderDate { get; set; }
        public DateTime EstimatedDate { get; set; }
        public bool Disabled { get; set; }
        public int OrderStatusId { get; set; }
        public bool IsNotification { get; set; }
    }
}
