using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //Get: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        //Post: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
            [Bind("ID, Title, releaseDate, Cost")] BookModel bookModel)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(bookModel);
        }
    }
}
