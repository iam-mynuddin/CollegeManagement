using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.DTOs
{
    public class AssignmentDto
    {
        public int AssignmentId { get; set; }

        public string Question { get; set; }

        public string Link { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int SubjectCode { get; set; }
       
        public int StudentId { get; set; }
       
    }
}
