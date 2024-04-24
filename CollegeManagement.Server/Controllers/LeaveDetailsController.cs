using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Server.Controllers
{
    public class LeaveDetailsController : MyBaseController
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveDetailsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost("requestleave")]
        public IActionResult RequestLeave(LeaveDetail leaveDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Request");
            }
            try
            {

                var Obj = new LeaveDetail();

                Obj.DateOfLeave = leaveDetail.DateOfLeave;
                Obj.IsApproved = false;
                Obj.UserId = leaveDetail.UserId;
                Obj.Reason = leaveDetail.Reason;

                _dbContext.LeaveDetails.Add(Obj);

                return Ok();
            }
            catch
            {



                return BadRequest("Invalid Request");
            }
        }
        [HttpGet]
        [Route("getattendance")]
        public IActionResult GetAttendance()
        {
            var objList = _dbContext.LeaveDetails.ToList();
            return Ok(objList);

        }
        [HttpGet]
        [Route("getleavedetailsbyid/{studentId}")]
        public IActionResult GetStudentDetailsById(int studentId)
        {

            if (studentId != 0)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                var res = _dbContext.LeaveDetails.Select(x => x.UserId == studentId);

                if (res != null)
                {
                    return Ok(res);
                }

            }

            return NotFound();
        }
        //pending -rename
        [HttpPut]
        [Route("put/{LeaveDetailsId}")]
        public IActionResult put(int LeaveDetailsId)
        {
            var boolResult = _dbContext.LeaveDetails.Any(x => x.Id == LeaveDetailsId);
            if (boolResult)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
