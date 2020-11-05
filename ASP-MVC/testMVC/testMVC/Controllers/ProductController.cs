using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public string Display( string name, int id , string category)
        {
            return "ur name: " + name + " ur id: " + id + " ur category: " + category;
        }
    }
}