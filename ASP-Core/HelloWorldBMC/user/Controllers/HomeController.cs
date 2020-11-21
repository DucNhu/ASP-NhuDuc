using user.Models;
using Microsoft.AspNetCore.Mvc;

namespace user.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppUser obj = new AppUser
            {
                User = "ducnhu2k1@gmail.com",
                Pass = "*****"
            };
            return View();
        }
    }
}
