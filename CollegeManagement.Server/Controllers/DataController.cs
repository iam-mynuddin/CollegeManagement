
using CollegeManagement.Data;
using CollegeManagement.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Server.Controllers
{
	public class DataController : MyBaseController
	{
		private readonly ApplicationDbContext _dbContext;

		public DataController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		[HttpGet("getallusers")]
		public IActionResult GetAllUsers()
		{
			var objList = _dbContext.Users.Select(u=> 
			new UserDto { UserId=u.UserId,FullName=u.FirstName+" "+u.LastName,UserName=u.UserName,UserType=u.UserType}).ToList();
			return Ok(objList);
		}
		[HttpGet("getallfaculty")]
		public IActionResult GetAllFaculty()
		{
			var objList=_dbContext.Faculties.ToList();
			return Ok(objList);
		}
		[HttpGet("getallstudents")]
		public IActionResult GetAllStudents()
		{
			var objList = _dbContext.Students.ToList();
			return Ok(objList);
		}
		[HttpGet("getallparents")]
		public IActionResult GetAllParents()
		{
			var objList = _dbContext.Parents.ToList();
			return Ok(objList);
		}
		[HttpGet("getallcourses")]
		public IActionResult GetAllCourses()
		{
			var objList = _dbContext.Courses.ToList();
			return Ok(objList);
		}
		[HttpGet("getallsubjects")]
		public IActionResult GetAllSubjects()
		{
			var objList = _dbContext.Subjects.Include(u=>u.Course).ToList();
			return Ok(objList);
		}
		
	}
}
