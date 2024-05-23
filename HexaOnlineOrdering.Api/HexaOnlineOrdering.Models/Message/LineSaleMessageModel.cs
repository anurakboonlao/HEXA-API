using System;
using System.Collections.Generic;

namespace HexaOnlineOrdering.Models.Message
{
    public class LineSaleMessageModel
    {
        public string ZoneName { get; set; }
        public string DoctorName { get; set; }
        public string ClinicName { get; set; }
        public string PatientName { get; set; }
        public Dictionary<string,int> ProductTypeCount { get; set; }
        public DateTime? PickUpDate { get; set; }

        public LineSaleMessageModel()
        {
           
        }
    }
}
