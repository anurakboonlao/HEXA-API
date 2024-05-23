using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Options
{
    public class AWS3setting
    {
        public const string SECTION = "AWS3";
        public string SecretKey { get; set; }
        public string Accesskey { get; set; }
        public string HostEndPoint { get; set; }
        public string BucketName { get; set; }
        public string Region { get; set; }
        public string BaseUrl { get; set; }
    }
}
