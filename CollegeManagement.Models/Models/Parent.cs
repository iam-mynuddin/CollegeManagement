using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
   public class Parent
    {
        [Key]
        public int ParentId { get; set; }
        public string? ParentAddress { get; set; }
		public string? MobileNumber { get; set; }
		public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
