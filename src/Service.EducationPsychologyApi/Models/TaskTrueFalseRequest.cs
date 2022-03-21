using System.ComponentModel.DataAnnotations;

namespace Service.EducationPsychologyApi.Models
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}