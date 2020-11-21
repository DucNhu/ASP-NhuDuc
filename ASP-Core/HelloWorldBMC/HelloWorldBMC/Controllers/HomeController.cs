using HelloWorldBMC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldBMC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppMessage mess = new AppMessage
            {
                Message = "This is Message"
            };
            return View(mess);
        }
        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            //truyen data dung ViewBag
            ViewBag.Message = "Messaged Changed";
            return View(obj);
        }
    }
}
