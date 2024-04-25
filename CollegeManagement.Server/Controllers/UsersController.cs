using CollegeManagement.Data;
using CollegeManagement.Models;
using CollegeManagement.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Server.Controllers
{
	public class UsersController : MyBaseController
	{
		private readonly ApplicationDbContext _dbContext;

		public UsersController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		[HttpPost("registeruser")]
		public IActionResult RegisterUser(UserDto obj)
		{
			if (obj == null) { return BadRequest(); }
			User usObj = new();
			usObj.Email = obj.MailId;
			usObj.FirstName = obj.FirstName;
			usObj.LastName = obj.LastName;
			usObj.UserType = obj.UserType;
			usObj.Password=obj.Password;
			usObj.UserName=obj.FirstName.ToString().ToLower().Substring(0, Math.Min(obj.FirstName.Length, 4))+
				obj.LastName.ToString().ToLower().Substring(0, Math.Min(obj.LastName.Length, 4));
			_dbContext.Users.Add(usObj);
			_dbContext.SaveChanges();
			return Ok("User added");
		}

		[HttpPost("updateuser")]
		public IActionResult UpdateUser(UserDto obj)
		{
			if (obj == null) { return BadRequest(); }

			User usObj = _dbContext.Users.FirstOrDefault(x=>x.UserName==obj.UserName);
			usObj.Email = obj.MailId;
			usObj.FirstName = obj.FirstName;
			usObj.LastName = obj.LastName;
			_dbContext.Users.Update(usObj);
			if (obj.UserType == "Student")
			{
				Student targetObj = new();
				targetObj.UserId = obj.UserId;
				targetObj.Address = obj.Address;
				targetObj.MobileNumber = obj.MobileNumber;
				targetObj.FullName = obj.FirstName+" "+obj.LastName;
				targetObj.MailId = obj.MailId;
				targetObj.StudentYear = obj.StudentYear;
				targetObj.StudentDepartment = obj.Department;
				if(!_dbContext.Students.Any(u=>u.UserId==obj.UserId)) 
					_dbContext.Students.Add(targetObj);
				else
				{
					targetObj.StudentId=(int)_dbContext.Students.FirstOrDefault(u=>u.UserId==obj.UserId).UserId;
					_dbContext.Students.Update(targetObj);
				}
			}
			else if(obj.UserType =="Parent")
			{
				Parent targetObj = new();
				targetObj.UserId = obj.UserId;
				targetObj.Address = obj.Address;
				targetObj.MobileNumber = obj.MobileNumber;
				targetObj.FullName = obj.FirstName + " " + obj.LastName;
				targetObj.MailId = obj.MailId;
				if (!_dbContext.Parents.Any(u => u.UserId == obj.UserId))
					_dbContext.Parents.Add(targetObj);
				else
				{
					targetObj.ParentId = (int)_dbContext.Students.FirstOrDefault(u => u.UserId == obj.UserId).UserId;
					_dbContext.Parents.Update(targetObj);
				}
			}
			else if (obj.UserType =="Faculty")
			{
				Faculty targetObj = new();
				targetObj.UserId = obj.UserId;
				targetObj.Address = obj.Address;
				targetObj.MobileNumber = obj.MobileNumber;
				targetObj.FullName = obj.FirstName + " " + obj.LastName;
				targetObj.MailId = obj.MailId;
				targetObj.FacultyDepartment = obj.Department;
				if (!_dbContext.Faculties.Any(u => u.UserId == obj.UserId))
					_dbContext.Faculties.Add(targetObj);
				else
				{
					targetObj.FacultyId = (int)_dbContext.Faculties.FirstOrDefault(u => u.UserId == obj.UserId).UserId;
					_dbContext.Faculties.Update(targetObj);
				}
			}
			if (_dbContext.ChangeTracker.HasChanges())
			{
				_dbContext.SaveChanges();
			}
			return Ok("User updated");
		}
	}
}
