using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models.DTOs
{
	public class UserDto
	{
		public string? UserName { get; set; }
		public string? Password { get; set; }
		public string? OldPassword { get; set; }
		public string? MailId { get; set; }
		public string? MobileNumber { get; set; }
		public string? Address { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? StudentYear { get; set; }
		public string? UserType { get; set; }
		public string? Department { get; set; }
		public string? FullName { get; set; }
		public int? UserId { get; set; }
	}
}
