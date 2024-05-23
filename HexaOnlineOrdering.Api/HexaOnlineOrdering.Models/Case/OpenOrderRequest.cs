using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class OpenOrderRequest
    {
        public int CaseId { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
