using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.Orders
{
    public class SelectedProduct
    {
        public string No { get; set; }
        public string Option { get; set; }
        public string ProductName { get; set; }
        public string MeterialName { get; set; }
        public string DesignName { get; set; }

        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }
        public string Method { get; set; }

        public List<SelectedAddOn> SelectedAddOns { get; set; }
        public string Shade { get; set; }
        public string ShadeSystem { get; set; }
        public int Age { get; set; }
        public GenderEnum? Gender { get; set; }
    }
}
