using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Server.Controllers
{
    public class AttendanceController : MyBaseController
	{
        private readonly ApplicationDbContext _dbContext;
        public AttendanceController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Route("getattendancelist")]
        [HttpGet]
        public IActionResult GetAttendance()
        {
            var entry = _dbContext.Attendances.ToList();

            List<Attendance> dto = new List<Attendance>();
            foreach (var entries in entry)
            {
                dto.Add(new Attendance { AttendanceDate = entries.AttendanceDate, StudentId = entries.StudentId, FacultyId = entries.FacultyId, IsPresent = entries.IsPresent });
            }
            return Ok(dto);
        }
        [Route("addattendance")]
        [HttpPost]
        public IActionResult AddAttendance(Attendance obj)
        {
            try
            {
                _dbContext.Attendances.Add(obj);
                return Ok();
            }
            catch
            {
                return
                    BadRequest("Failed to add data");
            }
        }
        [Route("getattendancebyid/{studentid}")]
        [HttpGet]
        public IActionResult GetAttendanceById(int studentid)
        {
            if (studentid != 0)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var res = _dbContext.Attendances.FirstOrDefault(x => x.StudentId == studentid);
                if (res != null)
                {
                    return Ok(res);
                }

            }
            return NotFound();
        }
    }
}