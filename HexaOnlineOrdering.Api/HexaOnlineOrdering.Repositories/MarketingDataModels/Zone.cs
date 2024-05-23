
using System;
using System.Collections.Generic;

namespace HexaOnlineOrdering.Repositories.MarketingDataModels
{
    public partial class Zone
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<ZoneMember> ZoneMembers { get; set; }
    }
}
