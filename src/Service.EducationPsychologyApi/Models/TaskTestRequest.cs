using System.ComponentModel.DataAnnotations;

namespace Service.EducationPsychologyApi.Models
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}