using System;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.Models.ERP
{
    public class SaleOrderStatusModel
    {
        [JsonProperty("ref")]
        public string Reference { get; set; }
        [JsonProperty("store_work_state")]
        public string Status { get; set; }
    }

    public enum SaleOrderStatus
    {
        DRAFT, // Draft
        WAITING, // Waiting Order
        ORDERED, // Ordered
        DEVELIVERD, // Delivery
        COMPLETED // Completed
    }
}
