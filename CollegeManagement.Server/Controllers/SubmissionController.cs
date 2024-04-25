using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CollegeManagement.Server.Controllers
{
    public class SubmissionController : MyBaseController
    {
        private readonly ApplicationDbContext _dbContext;

        public SubmissionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("getassignmentsubmissions")]
        public IActionResult GetSubmissions()
        {
            var objList = _dbContext.AssignmentSubmissions.ToList();
            return Ok(objList);

        }
        [HttpPost("submitassignment")]
        public IActionResult SubmitAssignment(AssignmentSubmission obj)
        {
            try
            {
                _dbContext.AssignmentSubmissions.Add(obj);
                return Ok();
            }
            catch
            {
                return
                    BadRequest("Failed to add data");
            }
        }
    }
}
