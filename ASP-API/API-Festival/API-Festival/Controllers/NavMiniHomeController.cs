using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using API_Festival.Models;

namespace API_Festival.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavMiniHomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public NavMiniHomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Get
        [HttpGet] 
        public JsonResult Get()
        {
            string query = @"select * from navigation";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("FestivalAppCon");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
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

        //post
        [HttpPost]
        public JsonResult Post(FesNav nav)
        {
            string query = "insert into navigation values " +
                "('" 
                + nav.name 
                + @"', " 
                + nav.active 
                + @"
                )";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("FestivalAppCon");
            SqlDataReader myReader;

            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close(); myCon.Close();
                }
            }
            return new JsonResult("Insert 100%");
        }

        //Delete
        [HttpDelete("{id}")]
        public JsonResult delete(int id)
        {
            string query = @"delete navigation
                    where id = " + id + @"";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("FestivalAppCon");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close(); myCon.Close();
                }
            }
            return new JsonResult("OK delete 100%");
        }

        // PUT
        [HttpPut]
        public JsonResult Put(FesNav festival)
        {
            string query = @"update dbo.fescategory set
                            name = '" + festival.name + @"',
                            active = " + festival.active + @"
                            where id = " + festival.id + @"";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("FestivalAppCon");
            SqlDataReader myRender;

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myRender = myCommand.ExecuteReader();
                    table.Load(myRender);
                    myRender.Close();
                    myCon.Close();
                }
                return new JsonResult("Ok delete 100%");
            }
        }
    }
}
