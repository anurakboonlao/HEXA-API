using System;
using System.Collections.Generic;
using HexaOnlineOrdering.Models.Enums;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.Models.ERP
{
    public class SaleOrderProduct
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class SaleOrderClassProduct : SaleOrderProduct
    {
        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("sub_products")]
        public List<SaleOrderSubProduct> SubProducts { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("shades")]
        public ShadesOfProduct Shades { get; set; }
    }
    public class ShadesOfProduct
    {
        [JsonProperty("shade")]
        public string Shade { get; set; }

        [JsonProperty("shade_system")]
        public string ShadeSystem { get; set; }

        [JsonProperty("subsitute_tooth")]
        public string SubsituteTooth { get; set; }
    }
    public class SaleOrderSubProduct : SaleOrderProduct
    {
        [JsonProperty("qty")]
        public int Qty { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class SaleOrderMainProduct
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("product_type")]
        public string ProductType
        {
            get
            {
                switch (Type)
                {
                    case Enums.ProductType.CROWNANDBRIDGES:
                        return "crown&bridges";
                    case Enums.ProductType.OTHODONTIC:
                        return "orthodontic";
                    case Enums.ProductType.OTHOPEDIC:
                        return "orthopedic";
                    case Enums.ProductType.REMOVEABLE:
                        return "removeable";
                    default:
                        return "";
                }
            }
        }

        [JsonIgnore]
        public ProductType Type { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }

        [JsonProperty("products")]
        public List<SaleOrderClassProduct> Products { get; set; }

    }
}
