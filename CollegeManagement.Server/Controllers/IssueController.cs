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
            var objList = _dbContext.IssueReports.Include(u=>u.User).ToList();

            //List<IssueReport> dto = new List<IssueReport>();
            //foreach (var obj in objList)
            //{
            //    dto.Add(new IssueReport { Ticket = obj.Ticket, Description = obj.Description, UserId = obj.UserId });
            //}
            return Ok(objList);
        }
		[HttpPost("raiseissue")]
        public IActionResult RaiseIssue(IssueReport obj)
        {
            try
            {
                _dbContext.IssueReports.Add(obj);
                return Ok();
            }
            catch
            {
                return BadRequest("Failed to add data");
            }

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
        //pending - rename
        [HttpPut]
        [Route("put/{ticketId}")]
        public IActionResult put(int ticketId)
        {
            var boolResult = _dbContext.IssueReports.Any(x => x.Ticket == ticketId);
            if (boolResult == true)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
