
using Microsoft.AspNetCore.Mvc;
using LearnAjax.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LearnAjax.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class learnAjaxController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public learnAjaxController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //Get
        [HttpGet] 
        public JsonResult Get()
        {
            string query = @"select * from nav";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("LeanAjax");

            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close(); myCon.Close();
                }
            }
                return new JsonResult(table);
        }
    }
}
