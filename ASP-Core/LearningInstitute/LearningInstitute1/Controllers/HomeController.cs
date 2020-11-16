using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningInstitute1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult messagepage() {
            return PartialView("MainMenu");

        }

        public ActionResult Courses()
        {
            return View();
        }
        [HttpGet]
        public JavaScriptResult WarningMessage()
        {
            var msg = "alert('The courses are available for 2 months on trial')";
            return new JavaScriptResult { Script = msg };
        }

        [HttpGet]
        public FileResult Dowload()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath(@"~/MyFile.txt"));
            string fileName = "MyFile.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public RedirectResult CourseMaterial()
        {
            return Redirect("Dowload");
        }

    }
}