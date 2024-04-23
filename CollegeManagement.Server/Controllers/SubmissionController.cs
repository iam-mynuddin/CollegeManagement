using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;


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
            var entry = _dbContext.AssignmentSubmissions.ToList();

            List<AssignmentSubmission> dto = new List<AssignmentSubmission>();
            foreach (var entries in entry)
            {
                dto.Add(new AssignmentSubmission { SubmissionId = entries.SubmissionId, SubmissionDate = entries.SubmissionDate, StudentId = entries.StudentId, CourseCode = entries.CourseCode });
            }
            return Ok(dto);

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
