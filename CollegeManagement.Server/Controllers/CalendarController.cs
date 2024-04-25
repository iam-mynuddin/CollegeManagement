using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Server.Controllers
{
    public class CalendarController : MyBaseController
    {
        private readonly ApplicationDbContext _dbContext;
        public CalendarController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("getcalendarlist")]
        [HttpGet]
        public IActionResult GetCalendarList()
        {
            var objList = _dbContext.Calendars.ToList();

            return Ok(objList);
        }
        [HttpPost("addcalendar")]
        public IActionResult AddCalendar(Calendar obj)
        {
            try
            {
                var entry = _dbContext.Calendars.Add(obj);
                return Ok();

            }
            catch
            {
                return BadRequest("Failed to add data");

            }

        }
    }
}

