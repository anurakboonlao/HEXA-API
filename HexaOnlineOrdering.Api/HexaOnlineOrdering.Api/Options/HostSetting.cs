using System;
namespace HexaOnlineOrdering.Api.Options
{
    public class HostSetting
    {
        public const string SECTION = "Host";
        public string Scheme { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
