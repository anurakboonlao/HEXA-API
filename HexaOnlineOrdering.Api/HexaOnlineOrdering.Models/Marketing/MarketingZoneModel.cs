using System;
using System.Collections.Generic;

namespace HexaOnlineOrdering.Models.Marketing
{
    public class MarketingZoneModel
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeletedAt { get; set; }
        public List<MarketingZoneMemberModel> ZoneMembers { get; set; }
    }
}
