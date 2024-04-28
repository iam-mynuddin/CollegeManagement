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
        [Required]
        public string StudentDepartment { get; set; }
		[Required]
		public string StudentYear { get; set; }
		[Required]
		public string MailId { get; set; }
		[Required]
		public string MobileNumber { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string FullName { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

	}
}
