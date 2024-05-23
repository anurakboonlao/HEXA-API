using System;
using System.Collections.Generic;

#nullable disable

namespace HexaOnlineOrdering.Repositories.MarketingDataModels
{
    public partial class Member
    {
        public uint Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerVerifyKey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string Type { get; set; }
        public string Role { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? ProvinceId { get; set; }
        public string Address { get; set; }
        public bool? Notification { get; set; }
        public string Content { get; set; }
        public string EoCusId { get; set; }
        public int Point { get; set; }
        public DateTime? PointExpire { get; set; }
        public int ZoneId { get; set; }
        public string EmailNoti { get; set; }
        public string PhoneNoti { get; set; }
        public string LineId { get; set; }
        public string LineUserId { get; set; }
        public string LineSecretCode { get; set; }
    }
}
