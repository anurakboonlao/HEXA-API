using System;
using System.Collections.Generic;

#nullable disable

namespace HexaOnlineOrdering.Repositories.EOrderDataModels
{
    public partial class Clinic
    {
        public string Code { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }
        public int ClinicGroupId { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int ClinicId { get; set; }
        public long? ClinicCusId { get; set; }
        public bool? ClnActive { get; set; }
    }
}
