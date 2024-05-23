using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Options
{
    public class EmailSetting
    {
        public const string SECTION = "EmailService";
        public string Port { get; set; }
        public string Host { get; set; }
        public string Timeout { get; set; }
        public string FromAddress { get; set; }
        public string FromPassword { get; set; }
    }
}
