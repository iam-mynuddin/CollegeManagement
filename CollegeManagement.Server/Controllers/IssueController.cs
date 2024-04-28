using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Server.Controllers
{
	public class IssueController : MyBaseController
	{
		private readonly ApplicationDbContext _dbContext;

		public IssueController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[Route("getissuereports")]
		[HttpGet]
		public IActionResult GetIssueReports()
		{
			var objList = _dbContext.IssueReports.Include(u => u.User).ToList();
			return Ok(objList);
		}
		[HttpPost("raiseissue")]
		public IActionResult RaiseIssue(IssueReport obj)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			_dbContext.IssueReports.Add(obj);
			_dbContext.SaveChanges();
			_dbContext.Entry(obj).Reload();
			return Ok(obj);
		}
		[HttpGet]
		[Route("getissuebyid/{userId}")]
		public IActionResult GetIssueById(int userId)
		{
			if (userId != 0)
			{
				if (!ModelState.IsValid)
					return BadRequest(ModelState);
				var res = _dbContext.IssueReports.Select(x => x.UserId == userId);
				if (res != null)
				{
					return Ok(res);
				}

			}
			return NotFound();
		}
		[HttpPut]
		[Route("updateissuereport/{ticketId}")]
		public IActionResult UpdateIssueReport(int ticketId)
		{
			var boolResult = _dbContext.IssueReports.Any(x => x.TicketId == ticketId);
			if (boolResult == true)
			{
				return Ok();
			}
			return BadRequest();
		}
	}
}
