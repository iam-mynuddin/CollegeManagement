using CollegeManagement.Data;
using CollegeManagement.Models;
using CollegeManagement.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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
		public IActionResult RegisterUser(User obj)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			User usObj = new();
			usObj.Email = obj.Email;
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
			User usObj = _dbContext.Users.FirstOrDefault(x=>x.UserId==obj.UserId);
			if (usObj == null) { return BadRequest(); }
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
				targetObj.StudentId=(int)_dbContext.Students.AsNoTracking().FirstOrDefault(u=>u.UserId==obj.UserId).StudentId;
				if(targetObj.StudentId==null || targetObj.StudentId<1)
				{
					_dbContext.Students.Add(targetObj);
				}
				else
				{
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
				if (!_dbContext.Parents.AsNoTracking().Any(u => u.UserId == obj.UserId))
					_dbContext.Parents.Add(targetObj);
				else
				{
					targetObj.ParentId = (int)_dbContext.Parents.AsNoTracking().FirstOrDefault(u => u.UserId == obj.UserId).UserId;
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
				if (!_dbContext.Faculties.AsNoTracking().Any(u => u.UserId == obj.UserId))
					_dbContext.Faculties.Add(targetObj);
				else
				{
					targetObj.FacultyId = (int)_dbContext.Faculties.AsNoTracking().FirstOrDefault(u => u.UserId == obj.UserId).UserId;
					_dbContext.Faculties.Update(targetObj);
				}
			}
			if (_dbContext.ChangeTracker.HasChanges())
			{
				_dbContext.SaveChanges();
			}
			return Ok(new {message="Successfully updated user"});
		}
	}
}
