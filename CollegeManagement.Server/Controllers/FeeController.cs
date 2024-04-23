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
            var entry = _dbContext.FeeDetails.ToList();

            List<FeeDetail> dto = new List<FeeDetail>();
            foreach (var entries in entry)
            {
                dto.Add(new FeeDetail { FeeId = entries.FeeId, Amount = entries.Amount, DateOfPayment = entries.DateOfPayment, StudentId = entries.StudentId });
            }
            return Ok(dto);

        }
        [HttpPost("uploadfeedetails")]
        public IActionResult UploadFeeDetails(FeeDetail obj)
        {
            try
            {
                var entry = _dbContext.FeeDetails.Add(obj);

                return Ok();
            }
            catch
            {
                return
                    BadRequest("Failed to add data");
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
