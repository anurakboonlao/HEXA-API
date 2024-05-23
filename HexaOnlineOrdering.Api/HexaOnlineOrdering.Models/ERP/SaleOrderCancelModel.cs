using System;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.Models.ERP
{
    public class SaleOrderCancelModel
    {
        [JsonProperty("ref")]
        public string Reference { get; set; }
    }
}
