using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.MarketingDataModels
{
    public partial class ZoneMember
    {
        public uint Id { get; set; }
        [ForeignKey("Zone")]
        public uint ZoneId { get; set; }
        [ForeignKey("Member")]
        public uint MemberId { get; set; }
        public DateTime? DeletedAt { get; set; }        
        public Zone Zone { get; set; }      
        public Member Member { get; set; }
    }
}
