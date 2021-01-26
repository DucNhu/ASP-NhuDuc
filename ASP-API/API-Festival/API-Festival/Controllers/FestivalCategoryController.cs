using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using API_Festival.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace API_Festival.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FestivalCategoryController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public FestivalCategoryController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"select * from dbo.fescategory";
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
            }
            return new JsonResult(table);
        }

        //Post
        [HttpPost]
        public JsonResult Post(FesCategory category)
        {

            string query = @"insert into dbo.fescategory values
                        ('" 
                        + category.name + @"',"
                        + category.active + @"',"
                        + category.img + @"
                        )";

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
            }
            return new JsonResult("Ok post 100%");
        }

        //Delete
        [HttpDelete("{id}")] 
        public JsonResult Delete(int id)
        {
            string query = @"delete from dbo.fescategory 
                        where id = " + id + @"";

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

        // PUT
        [HttpPut]
        public JsonResult Put(FesCategory festival)
        {
            string query = @"update dbo.fescategory set
                            name = '" + festival.name + @"', 
                            active = " + festival.active + @",
                            img = " + festival.img + @"
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
                var physicalPath = _env.ContentRootPath + "/photobyCategory/" + filename;
                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }
                return new JsonResult(filename);
            }

            catch (Exception)
            {
                return new JsonResult("ok Done insert Img Category");
            }
        }
    }
}
