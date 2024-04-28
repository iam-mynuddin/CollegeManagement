using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
			var objList = _dbContext.Attendances.Include(u => u.Student).Include(u => u.Faculty);
			return Ok(objList);
		}
		[HttpPost]
		[Route("addattendance")]
		public IActionResult AddAttendance(Attendance obj)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			_dbContext.Attendances.Add(obj);
			_dbContext.SaveChanges();
			_dbContext.Attendances.Entry(obj).Reload();
			return Ok(obj);
		}
		[Route("getattendancebystudentid/{id}")]
		[HttpGet]
		public IActionResult GetAttendanceByStudentId(int id)
		{
			if (id != 0)
			{
				var res = _dbContext.Attendances.FirstOrDefault(x => x.StudentId == id);
				if (res != null)
				{
					return Ok(res);
				}

			}
			return NotFound();
		}
		[Route("getattendancebyfacultyid/{id}")]
		[HttpGet]
		public IActionResult GetAttendanceByFacultyId(int id)
		{
			if (id != 0)
			{
				var res = _dbContext.Attendances.FirstOrDefault(x => x.FacultyId == id);
				if (res != null)
				{
					return Ok(res);
				}

			}
			return NotFound();
		}
	}
}