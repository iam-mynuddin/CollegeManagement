using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Server.Controllers
{
    public class AssignmentController : MyBaseController
    {
        private readonly ApplicationDbContext _dbContext;
        public AssignmentController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        [Route("uploadassignmentques")]
        public IActionResult UploadAssignmentQues(Assignment obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                _dbContext.Assignments.Add(obj);
                return Ok("Assignment Uploaded Successfully!");
            }
            catch
            {
                return BadRequest("Failed to Upload Assignments");
            }
        }
        [HttpGet]
        [Route("getassignments")]
        public IActionResult GetAssignments()
        {
            var objList = _dbContext.Assignments.ToList();
            return Ok(objList);
        }
        [HttpGet]
        [Route("getassignmentbyid/{studentid}")]
        public IActionResult GetAssignmentById(int studentid)
        {
            if (studentid != 0)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var res = _dbContext.Assignments.Select(x => x.StudentId == studentid);
                if (res != null)
                {
                    return Ok(res);
                }
            }
            return NotFound();
        }
    }
}