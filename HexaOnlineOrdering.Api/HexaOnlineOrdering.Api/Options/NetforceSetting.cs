using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Options
{
    public class NetforceSetting
    {
        public const string SECTION = "Netforce";

        public string ApiUrl { get; set; }
        public string Method { get; set; }
        public string Database { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string Id { get; set; }
    }
}
