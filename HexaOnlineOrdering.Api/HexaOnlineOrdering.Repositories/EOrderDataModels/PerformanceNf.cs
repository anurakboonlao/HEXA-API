using System;
using System.Collections.Generic;

#nullable disable

namespace HexaOnlineOrdering.Repositories.EOrderDataModels
{
    public partial class PerformanceNf
    {
        public uint PdId { get; set; }
        public string Code { get; set; }
        public int? CategId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? UomId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool? Active { get; set; }
        public int PerStatus { get; set; }
    }
}
