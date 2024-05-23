using System;
using System.Collections.Generic;

#nullable disable

namespace HexaOnlineOrdering.Repositories.EOrderDataModels
{
    public partial class PerformanceProduct
    {
        public int ProId { get; set; }
        public string ProIdOld { get; set; }
        public string ProCode { get; set; }
        public string ProCatalog { get; set; }
        public string ProName { get; set; }
        public string ProDepart { get; set; }
    }
}
