using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models.Models
{
	public class Subject
	{
		[Key]
		public int SubjectId { get; set; }
		[Required]
		public string SubjectName { get; set; }
		public int? CourseId { get; set; }
		[ForeignKey("CourseId")]
		public Course Course { get; set; }

	}
}
