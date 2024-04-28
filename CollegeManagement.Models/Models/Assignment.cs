using CollegeManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public string Question { get; set; }
        public string Status { get; set; }
        public DateTime? AllotedDate { get; set; } = DateTime.UtcNow;
        public DateOnly? TargetDate { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
		public int? SubjectId { get; set; }
		[ForeignKey("SubjectId")]
		public Subject? Subject { get; set; }
		public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
		public int? FacultyId { get; set; }
		[ForeignKey("FacultyId")]
		public Faculty? Faculty { get; set; }
	}
}
