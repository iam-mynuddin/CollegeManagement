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
   public class Parent
    {
		[Key]
		public int ParentId { get; set; }
		[AllowNull]
		public string? MailId { get; set; }
		[Required]
		public string MobileNumber { get; set; }
		[Required]
		public string Address { get; set; }
		public int UserId { get; set; }
		[ForeignKey("UserId")]
		public User User { get; set; }
		[Required]
		public string FullName { get; set; }

	}
}
