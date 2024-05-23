using System;
using System.Collections.Generic;

#nullable disable

namespace HexaOnlineOrdering.Repositories.EOrderDataModels
{
    public partial class Doctor
    {
        public int DoctorId { get; set; }
        public string ClinicCode { get; set; }
        public string Address { get; set; }
        public string DocName { get; set; }
        public uint DocCusId { get; set; }
        public DateTime? DocLastupdate { get; set; }
        public bool? DocActive { get; set; }
    }
}
