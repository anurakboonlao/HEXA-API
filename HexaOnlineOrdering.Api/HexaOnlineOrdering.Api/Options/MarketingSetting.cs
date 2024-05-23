using System;
namespace HexaOnlineOrdering.Api.Options
{
    public class MarketingSetting
    {
        public const string SECTION = "MarketingWebsite";

        public string WebUrl { get; set; }
        public string PicturePath { get; set; }
    }
}
