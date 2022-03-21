using System.ComponentModel.DataAnnotations;

namespace Service.EducationPsychologyApi.Models
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}