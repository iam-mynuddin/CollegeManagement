using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class AssignmentSubmission
    {
        [Key]
        public int SubmissionId { get; set; }

        public string Answer { get; set; }

        public DateTime SubmissionDate { get; set; }

        public int? StudentId { get; set; }
        //[ForeignKey("StudentId")]
        //public Student? Student { get; set; }

        public int? CourseCode { get; set; }
        //[ForeignKey("CourseCode")]
        //public Course? Course { get; set; }

    }
}
