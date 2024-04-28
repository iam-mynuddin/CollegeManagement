using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Server.Controllers
{
	public class LeaveDetailsController : MyBaseController
	{
		private readonly ApplicationDbContext _dbContext;
		public LeaveDetailsController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		[HttpPost("requestleave")]
		public IActionResult RequestLeave(LeaveDetail obj)
		{
			if (!ModelState.IsValid) return BadRequest("Invalid Request");
			_dbContext.LeaveDetails.Add(obj);
			_dbContext.SaveChanges();
			_dbContext.LeaveDetails.Entry(obj).Reload();
			return Ok(obj);
		}
		[HttpGet]
		[Route("getattendance")]
		public IActionResult GetAttendance()
		{
			var objList = _dbContext.LeaveDetails.ToList();
			return Ok(objList);

		}
		[HttpGet]
		[Route("getleavedetailsbyid/{userId}")]
		public IActionResult GetLeaveDetailsById(int userId)
		{
			if (userId != 0)
			{
				var res = _dbContext.LeaveDetails.Select(x => x.UserId == userId);
				if (res == null) return NotFound();
				return Ok(res);
			}
			return BadRequest();
		}
		[HttpGet]
		[Route("getleaverequests")]
		public IActionResult GetLeaveRequests()
		{
			var res = _dbContext.LeaveDetails.Where(u => u.IsApproved == false).Include(u => u.User).ToList();
			return Ok(res);
		}
		[HttpGet]
		[Route("getleavehistory")]
		public IActionResult GetLeaveHistory()
		{
			var res = _dbContext.LeaveDetails.Where(u => u.DateOfLeave < DateOnly.FromDateTime(DateTime.UtcNow)).Include(u => u.User).ToList();
			return Ok(res);
		}
		[HttpPut]
		[Route("updateleaverequest/{id}")]
		public IActionResult UpdateLeaveRequest(int id)
		{
			var boolResult = _dbContext.LeaveDetails.Any(x => x.Id == id);
			if (boolResult)
			{
				return Ok();
			}
			return BadRequest();
		}
	}
}
