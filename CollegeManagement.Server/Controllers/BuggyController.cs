using CollegeManagement.Data;
using CollegeManagement.Models;
using CollegeManagement.Server.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	public class BuggyController : MyBaseController
	{
		private readonly ApplicationDbContext _context;

		public BuggyController(ApplicationDbContext context)
		{
			_context = context;
		}
		[Authorize]
		[HttpGet("auth")]
		public ActionResult<string> GetSecretText()
		{
			return "This is just to test";
		}
		[HttpGet("not-found")]
		public ActionResult<User> GetNotFound()
		{

			var objNotFound = _context.Users.Find(-1);
			if (objNotFound == null) return NotFound();
			return objNotFound;
		}
		[HttpGet("server-error")]
		public ActionResult<string> GetServerError()
		{
			var objServerError = _context.Users.Find(-1);
			var strServerError = objServerError.ToString();
			return strServerError;
		}
		[HttpGet("bad-request")]
		public ActionResult<string> GetBadRequest()
		{
			return BadRequest("This is bad rquest");
		}

	}

}
