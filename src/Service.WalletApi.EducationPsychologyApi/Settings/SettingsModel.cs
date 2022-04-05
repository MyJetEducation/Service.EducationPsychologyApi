using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationPsychologyApi.Settings
{
    public class SettingsModel
    {
        [YamlProperty("EducationPsychologyApi.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("EducationPsychologyApi.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("EducationPsychologyApi.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("EducationPsychologyApi.EnableApiTrace")]
        public bool EnableApiTrace { get; set; }

        [YamlProperty("EducationPsychologyApi.MyNoSqlReaderHostPort")]
        public string MyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationPsychologyApi.AuthMyNoSqlReaderHostPort")]
        public string AuthMyNoSqlReaderHostPort { get; set; }

        [YamlProperty("EducationPsychologyApi.SessionEncryptionKeyId")]
        public string SessionEncryptionKeyId { get; set; }

        [YamlProperty("EducationPsychologyApi.MyNoSqlWriterUrl")]
        public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationPsychologyApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
    }
}
