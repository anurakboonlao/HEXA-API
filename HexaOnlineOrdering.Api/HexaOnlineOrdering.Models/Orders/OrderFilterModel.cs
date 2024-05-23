using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class OrderFilterModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int[] Status { get; set; }
        public int ProductTypeId { get; set; }
        public int SearchType { get; set; }
        public string SearchStr { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public string sortOrder { get; set; }
    }
}
