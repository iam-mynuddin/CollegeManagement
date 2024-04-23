using CollegeManagement.Data;
using CollegeManagement.Models;
using CollegeManagement.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Server.Controllers
{
    public class LoginController : MyBaseController
    {
        private readonly ApplicationDbContext _dbContext;

        public LoginController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("login")]
        public IActionResult Login(UserDto user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var res = _dbContext.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (res == null)
                return BadRequest("Invalid Username/Password");
            return Ok(res);
        }
        [HttpGet("supersecret")]
        public ActionResult<IEnumerable<User>> SuperSecret() 
        {
            return _dbContext.Users;
        }
    }

}
