﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyMail { get; set; }
		public string? MobileNumber { get; set; }
		public string FacultyAddress { get; set; }
        public DateTime FacultyDoj { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }


    }
}
