using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ASP_API_ANGULAR.Controllers
{
    public class DapartmentController : ApiController
    {
        //public HttpResponseMessage Get()
        //{
        //    string query = @"
        //        select DepartmentId,DepartmentName from dbo.Department
        //        ";
        //    DataTable table = new DataTable();
        //    using(var con = new SqlConnection(ConfigurationManager.
        //        ConnectionStrings["EmployeeAppDB"].ConnectonString))
        //        using(var cmd = new SqlCommand(query, con))
        //    using (var da = new SqlDataAdapter(cmd))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        da.Fill(table);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, table);
        //}
    }
}