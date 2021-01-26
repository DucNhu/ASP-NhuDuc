using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using API_Festival.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace API_Festival.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FestivalsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public FestivalsController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        //Get
        [HttpGet]
        public JsonResult Get()
        {
            string query = "select * from festival";
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
                    myRender.Close(); myCon.Close();
                }
            }
            return new JsonResult(table);
        }

        //Get by Id
        [Route("festivalDes/{id}")]
        [HttpGet]
        public JsonResult Get(int id)
        {
            string query = "select * from festival where id = " + id + @"";
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
                    myRender.Close(); myCon.Close();
                }
            }
            return new JsonResult(table);
        }

        //post
        [HttpPost]
        public JsonResult Post(Festival festival)
        {
            string query = @"insert into festival(NameCategory, NameNav, name, img , address, timeFirst, timeLast,price ,sale, description) values 
                ('"
                + festival.NameCategory + "', '"
                + festival.NameNav + "', '"
                + festival.name + "', '"
                + festival.img + "', '"
                + festival.address + "', '"
                + festival.timeFirst + "', '"
                + festival.timeLast + "', "
                + festival.price + ", "
                + festival.sale + ", '"
                + festival.description + @"'
                )";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("FestivalAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
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
            string query = "delete from festival " +
              "where id = " + id + @"";
            string sqlDataSource = _configuration.GetConnectionString("FestivalAppCon");
            DataTable table = new DataTable();
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close(); myCon.Close();
                }
            }
            return new JsonResult(table);

        }

        // PUT
        [HttpPut]
        public JsonResult Put(Festival festival)
        {
            string query = @"update dbo.festival set
                        NameCategory = '" + festival.NameCategory + "', " +
                        "NameNav  = '" + festival.NameNav + "', " +
                        "name = '" + festival.name + "', " +
                        "img = '" + festival.img + "', " +
                        "address = '" + festival.address + "', " +
                        "timeFirst = '" + festival.timeFirst + "', " +
                        "timeLast = '" + festival.timeLast + "', " +
                        "price = " + festival.price + ", " +
                        "sale = " + festival.sale + ", " +
                        "description = '" + festival.description + @" 
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
        
        //SaveFile
        [Route("savefile")]
        [HttpPost] 
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Photos/" + filename;
                using(var stream = new FileStream(physicalPath, FileMode.Create)) {
                    postedFile.CopyTo(stream);
                }
                return new JsonResult(filename);
            }

            catch(Exception)
            {
                return new JsonResult("anonymous.png");
            }
        }
    }
}

