using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        public int? StudentId { get; set; }
        //[ForeignKey("StudentId")]
        //public Student? Student { get; set; }
        public int? FacultyId { get; set; }
        //[ForeignKey("FacultyId")]
        //public Faculty? Faculty { get; set; }

    }
}
