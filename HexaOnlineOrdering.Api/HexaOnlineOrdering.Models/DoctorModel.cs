using System;
namespace HexaOnlineOrdering.Models
{
    public class DoctorModel
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
