using System;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.ERP.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        [JsonProperty("address_text")]
        public string AddressText { get; set; }
        [JsonProperty("cash_account_id")]
        public int CashAccountId { get; set; }
        [JsonProperty("disc_account_id")]
        public int DiscountAccountId { get; set; }
        public string Name { get; set; }
        [JsonProperty("shop_no")]
        public string ShopNumber { get; set; }
        public bool Active { get; set; }
    }
}
