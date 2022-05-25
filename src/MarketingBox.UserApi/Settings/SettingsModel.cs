using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace MarketingBox.UserApi.Settings
{
    public class SettingsModel
    {
        [YamlProperty("MarketingBoxUserApi.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("MarketingBoxUserApi.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("MarketingBoxUserApi.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("MarketingBoxUserApi.AuthServiceUrl")]
        public string AuthServiceUrl { get; set; }

        [YamlProperty("MarketingBoxUserApi.JwtAudience")]
        public string JwtAudience { get; set; }

        [YamlProperty("MarketingBoxUserApi.JwtSecret")]
        public string JwtSecret { get; set; }

        [YamlProperty("MarketingBoxUserApi.JwtTtl")]
        public string JwtTtl { get; set; }
    }
}
