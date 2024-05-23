using System;
namespace HexaOnlineOrdering.Api.Options
{
    public class JWTSetting
    {
        public const string SECTION = "JwtConfig";

        public string Secret { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}
