using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationPsychologyApi.Controllers.Contracts
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}