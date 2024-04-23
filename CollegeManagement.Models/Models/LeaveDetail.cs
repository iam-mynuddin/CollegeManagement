﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class LeaveDetail
    {
        [Key]
        public int LeaveDetailsId { get; set; }

        public string Reason { get; set; }

        public DateTime DateOfLeave { get; set; }

        public bool IsApproved { get; set; }

        public int? UserId { get; set; }
        //[ForeignKey("UserId")]
        //public User? User { get; set; }

    }
}