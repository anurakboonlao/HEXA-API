using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.Models
{
    public class NetforceRequestModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("dbname")]
        public string DBName { get; set; }
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// [conditions, columns]
        /// </summary>
        [JsonProperty("params")]
        public object[] ParamList { get; set; }
    }
}
