using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationPsychologyApi.Controllers.Contracts
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}