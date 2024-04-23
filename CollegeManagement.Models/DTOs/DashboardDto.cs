using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models.DTOs
{
	public class DashboardDto
	{
		public IEnumerable<Student> Students { get; set; }
		public IEnumerable<Faculty> Faculty { get; set;}
		public IEnumerable<Course> Courses { get; set; }
	}
}
