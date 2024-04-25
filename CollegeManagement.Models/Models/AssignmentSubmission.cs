using CollegeManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class AssignmentSubmission
    {
        [Key]
        public int SubmissionId { get; set; }
        public string? Answer { get; set; }
        public int? Status { get; set; }
        public string? Feedback {  get; set; }
        public bool? Reviewed { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int? AssignmentId { get; set; }
        [ForeignKey("AssignmentId")]
        public Assignment? Assignment { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
        public int? CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
		public int? SubjectId { get; set; }
		[ForeignKey("SubjectId")]
		public Subject? Subject { get; set; }

	}
}
