using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationPsychologyApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationPsychologyApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationPsychologyApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationPsychologyApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationPsychologyApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}
