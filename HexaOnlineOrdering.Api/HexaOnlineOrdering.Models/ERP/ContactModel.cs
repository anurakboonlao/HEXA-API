using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.ERP.Models
{
    public class ContactModel
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        [JsonProperty("doctor_ids")]
        public List<int> DoctorIds { get; set; }
    }
}
