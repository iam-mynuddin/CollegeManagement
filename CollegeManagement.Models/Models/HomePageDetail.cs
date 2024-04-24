using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models.Models
{

	[Index(nameof(Key), IsUnique = true)]
	public class HomePageDetail
	{
		public int Id { get; set; }
		[NotNull]
		[Required]
		public string? Key { get; set; }
		public string? Value { get; set; }
	}
}
