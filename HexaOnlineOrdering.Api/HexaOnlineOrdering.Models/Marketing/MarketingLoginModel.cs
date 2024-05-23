using System;
using System.ComponentModel.DataAnnotations;

namespace HexaOnlineOrdering.Models.Marketing
{
    public class MarketingLoginModel
    {
        [Required]
        public int ContactId { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
