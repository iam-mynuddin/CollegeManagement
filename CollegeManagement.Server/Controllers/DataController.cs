
using CollegeManagement.Data;
using CollegeManagement.Models;
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
			new UserDto { UserId=u.UserId,FirstName=u.FirstName,LastName=u.LastName,FullName=u.FirstName+" "+u.LastName,UserName=u.UserName,UserType=u.UserType}).ToList();
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
		[HttpGet("getallfaculties")]
		public IActionResult GetAllFaculties()
		{
			var objList = _dbContext.Faculties.ToList();
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

		[HttpGet("getuserbyid/{userId}")]
		public IActionResult GetUserById(int userId)
		{
			var user = _dbContext.Users.FirstOrDefault(u => u.UserId == userId);
			if (user == null) return NotFound();
			UserDto dtoObj = new();
			dtoObj.UserId = user.UserId;
			dtoObj.FirstName = user.FirstName;
			dtoObj.LastName = user.LastName;
			dtoObj.UserType = user.UserType;
			dtoObj.UserName = user.UserName;
			if (user != null)
			{
				switch (user.UserType)
				{
					case "Student":
						Student? student = _dbContext.Students.FirstOrDefault(u => u.UserId == user.UserId);
						if (student == null) { dtoObj.NeedUpdate = true; break; };
						dtoObj.FullName=student.FullName;
						dtoObj.Address = student.Address;
						dtoObj.MobileNumber = student.MobileNumber;
						dtoObj.MailId = student.MailId;
						dtoObj.StudentYear = student.StudentYear;
						dtoObj.Department = student.StudentDepartment; break;
					case "Faculty":
						Faculty? faculty = _dbContext.Faculties.FirstOrDefault(u => u.UserId == user.UserId);
						if (faculty == null) { dtoObj.NeedUpdate = true; break; }
						dtoObj.FullName=faculty.FullName;
						dtoObj.Address = faculty.Address;
						dtoObj.MobileNumber = faculty.MobileNumber;
						dtoObj.MailId = faculty.MailId;
						dtoObj.Department = faculty.FacultyDepartment; break;
					case "Parent":
						Parent? parent = _dbContext.Parents.FirstOrDefault(u => u.UserId == user.UserId);
						if (parent == null) { dtoObj.NeedUpdate = true; break; };
						dtoObj.FullName = parent.FullName;
						dtoObj.Address = parent.Address;
						dtoObj.MobileNumber = parent.MobileNumber;
						dtoObj.MailId = parent.MailId;
						break;
					case "Admin":
						dtoObj.MailId = user.Email;
						dtoObj.NeedUpdate = false;
						break;
					default: return NotFound();
				}
				return Ok(dtoObj);
			}
			return NotFound();
		}

	}
}
