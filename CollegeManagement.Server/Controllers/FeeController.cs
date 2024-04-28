using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Server.Controllers
{
	public class FeeController : MyBaseController
	{
		private readonly ApplicationDbContext _dbContext;

		public FeeController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpGet]
		[Route("getfeedetails")]
		public IActionResult GetFeeDetails()
		{
			var objList = _dbContext.FeeDetails.Include(u => u.Student).ToList();
			return Ok(objList);

		}
		[HttpPost("addfeedetails")]
		public IActionResult AddFeeDetails(FeeDetail obj)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			_dbContext.FeeDetails.Add(obj);
			_dbContext.SaveChanges();
			_dbContext.FeeDetails.Entry(obj).Reload();
			return Ok(obj);
		}

		[HttpGet]
		[Route("getfeedetailsbystudentid/{id}")]
		public IActionResult GetFeeDetailsById(int id)
		{
			if (id != 0)
			{
				var res = _dbContext.FeeDetails.Select(x => x.StudentId == id);
				if (res != null)
				{
					return Ok(res);
				}

			}
			return NotFound();
		}
	}
}
