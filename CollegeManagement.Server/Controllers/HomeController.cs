using CollegeManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using CollegeManagement.Server.Helpers;

namespace CollegeManagement.Server.Controllers
{
	public class HomeController : MyBaseController
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _config;
        public HomeController(ApplicationDbContext dbContext,IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }
        [HttpGet]
        [Route("homepagedetails")]
        public IActionResult HomePage()
        {
            var objResult=_dbContext.HomePageDetails.ToList();
            return Ok(objResult);
        }
        [HttpGet]
        [Route("dashboard")]
        public IActionResult GetDashboardDetailsADO() 
        {
            try
            {
                DataTable dtResult = new DataTable();
                using (SqlConnection con = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
                {
                    using (SqlCommand cmd = new SqlCommand("GetDashBoardDetail_SP"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            con.Open();
                            adapter.Fill(dtResult);
                        }
                    }
                    con.Close();
                }
                string jsonResult=JsonConvert.SerializeObject(dtResult);
			    return Ok(jsonResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
		[HttpGet]
		[Route("dashboardef")]
		public IActionResult GetDashboardDetailsEF()
		{
            return null;
		}
	}
}