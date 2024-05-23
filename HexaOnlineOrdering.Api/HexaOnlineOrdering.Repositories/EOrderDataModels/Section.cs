using System;
using System.Collections.Generic;

#nullable disable

namespace HexaOnlineOrdering.Repositories.EOrderDataModels
{
    public partial class Section
    {
        public int SectionId { get; set; }
        public string Type { get; set; }
        public string Room { get; set; }
        public string Department { get; set; }
        public int? Process { get; set; }
        public string SecType { get; set; }
        public string SecRoom { get; set; }
        public uint? SecProcess { get; set; }
        public bool? SecActive { get; set; }
        public bool ApiStat { get; set; }
        public DateTime? SecLastUpdate { get; set; }
    }
}
