using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.ERP.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }

        [JsonProperty("contact_ids")]
        public List<int> ContactIds { get; set; }
    }
}
