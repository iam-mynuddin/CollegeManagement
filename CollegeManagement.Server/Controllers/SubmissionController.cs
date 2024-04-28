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
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			var assignmentQuestion=_dbContext.Assignments.FirstOrDefault(x => x.AssignmentId == obj.AssignmentId);
                if (assignmentQuestion != null)
                {
                    assignmentQuestion.Status = "Answer submitted";
                    _dbContext.Assignments.Update(assignmentQuestion);
                }
                obj.Status = "Submitted";
				_dbContext.AssignmentSubmissions.Add(obj);
				_dbContext.SaveChanges();
				_dbContext.AssignmentSubmissions.Entry(obj).Reload();
				return Ok(obj);
			
        }
    }
}
