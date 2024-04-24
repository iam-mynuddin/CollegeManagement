using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Models
{
    public class Calendar
    {
        [Key]
        public int CalendarId { get; set; }
        public string Message {  get; set; }
        public DateTime DateOfEdit { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}
