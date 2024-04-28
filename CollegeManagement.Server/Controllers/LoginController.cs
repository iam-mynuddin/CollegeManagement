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
            if (user==null)
                return BadRequest("Bad request");
            if (!_dbContext.Users.Any(x => (x.UserName.ToLower() == user.UserName.ToLower() || x.Email.ToLower() == user.UserName.ToLower()))) 
                return Unauthorized("Invalid username");
            var res = _dbContext.Users.FirstOrDefault(x => (x.UserName == user.UserName ||x.Email==user.MailId) && x.Password == user.Password);
            if (res == null)
                return Unauthorized("Invalid password");
            UserDto userDto = new();
            userDto.UserName = res.UserName;
            userDto.UserId = res.UserId;
            userDto.FirstName = res.FirstName;
            userDto.LastName = res.LastName;
            userDto.UserType=res.UserType;
            return Ok(userDto);
        }
        [HttpGet("supersecret")]
        public ActionResult<IEnumerable<User>> SuperSecret() 
        {
            return _dbContext.Users;
        }
    }

}
