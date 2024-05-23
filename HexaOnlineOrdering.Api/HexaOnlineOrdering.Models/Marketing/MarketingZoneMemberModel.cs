using System;
namespace HexaOnlineOrdering.Models.Marketing
{
    public class MarketingZoneMemberModel
    {
        public uint Id { get; set; }
        public int ZoneId { get; set; }
        public int MemberId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public MarketingZoneModel Zone { get; set; }
        public MarketingMemberModel Member { get; set; }
    }
}
