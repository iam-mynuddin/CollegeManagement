using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;

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
            var objList = _dbContext.FeeDetails.ToList();
            return Ok(objList);

        }
        [HttpPost("uploadfeedetails")]
        public IActionResult UploadFeeDetails(FeeDetail obj)
        {
            try
            {
                var entry = _dbContext.FeeDetails.Add(obj);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest("Failed to add data");
            }
        }

        [HttpGet]
        [Route("getfeedetailsbyid/{studentid}")]
        public IActionResult GetFeeDetailsById(int studentid)
        {
            if (studentid != 0)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var res = _dbContext.FeeDetails.Select(x => x.StudentId == studentid);
                if (res != null)
                {
                    return Ok(res);
                }

            }
            return NotFound();
        }
    }
}
