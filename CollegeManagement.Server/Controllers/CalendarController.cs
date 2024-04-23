using CollegeManagement.Data;
using CollegeManagement.Models;
using CollegeManagement.DTOs;
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
            var entry = _dbContext.Calendars.ToList();

            List<CalendarDto> dto = new List<CalendarDto>();
            foreach (var entries in entry)
            {
                dto.Add(new CalendarDto { DateOfEdit = entries.DateOfEdit, Reason = entries.Reason, Status = entries.Status });
            }
            return Ok(dto);
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

