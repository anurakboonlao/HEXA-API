using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Options
{
    public class SmsSetting
    {
        public const string SECTION = "SMSService";
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public string Force { get; set; }
        public bool Shorten_url { get; set; }
        public string LinkPath { get; set; }
    }
}
