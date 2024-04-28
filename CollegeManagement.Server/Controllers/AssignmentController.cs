using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Server.Controllers
{
	public class AssignmentController : MyBaseController
	{
		private readonly ApplicationDbContext _dbContext;
		public AssignmentController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		[HttpPost]
		[Route("allotassignment")]
		public IActionResult UploadAssignmentQues(Assignment obj)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			obj.Status = "Pending";
			_dbContext.Assignments.Add(obj);
			_dbContext.SaveChanges();
			_dbContext.Assignments.Entry(obj).Reload();
			return Ok(obj);

		}
		[HttpGet]
		[Route("getassignments")]
		public IActionResult GetAssignments()
		{
			var objList = _dbContext.Assignments.Include(u => u.Student).Include(u => u.Faculty).Include(u => u.Course).Include(u => u.Subject).ToList();
			return Ok(objList);
		}
		[HttpGet]
		[Route("getpendingassignments")]
		public IActionResult GetPendingAssignments()
		{
			var objList = _dbContext.Assignments.Include(u => u.Student).Include(u => u.Course).Include(u => u.Subject).Where(u => u.Status == "Pending").ToList();
			return Ok(objList);
		}
		[HttpGet]
		[Route("getassignmentsbystudentid/{id}")]
		public IActionResult GetAssignmentByStduentId(int id)
		{
			if (id != 0)
			{
				var res = _dbContext.Assignments.Select(x => x.StudentId == id);
				if (res != null)
				{
					return Ok(res);
				}
			}
			return NotFound();
		}
		[HttpGet]
		[Route("getassignmentsbyfacultyid/{id}")]
		public IActionResult GetAssignmentByFacultyId(int id)
		{
			if (id != 0)
			{
				var res = _dbContext.Assignments.Select(x => x.FacultyId == id);
				if (res != null)
				{
					return Ok(res);
				}
			}
			return NotFound();
		}

	}
}