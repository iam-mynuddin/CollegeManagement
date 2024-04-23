using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentDepartment { get; set; }

        public string CourseName { get; set; }

        public string StudentMail { get; set; }

        public string? StudentMobile { get; set; }
        public string? StudentAddress { get; set; }

        public int? UserId { get; set; }
        //[ForeignKey("UserId")]
        //public User? User { get; set; }

       
    }
}
