using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace testMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Welcome(string name, int num = 1)
        {
            ViewBag.num = num;
            ViewBag.Message = name;
            return View();
        }

        //public string Index()
        //{
        //    return "xXx";
        //}

        public string MyName(string name, int old)
        {
            // Tranh bj hacker tan cong
            return HttpUtility.HtmlEncode("My Name: " + name + "My Old:" + old.ToString());
        }

    }
}