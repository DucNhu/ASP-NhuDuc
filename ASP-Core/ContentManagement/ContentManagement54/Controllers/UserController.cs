using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContentManagement54.CustomFilter;
using System.Web.Mvc;

namespace ContentManagement54.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [AuthLog(Roles = "User")]
        public ActionResult Index()
        {
            return View();
        }
    }
}