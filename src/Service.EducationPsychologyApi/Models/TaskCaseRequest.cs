using System.ComponentModel.DataAnnotations;

namespace Service.EducationPsychologyApi.Models
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}