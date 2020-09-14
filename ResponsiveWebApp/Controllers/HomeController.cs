using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResponsiveWebApp.Models;

namespace ResponsiveWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.Age = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(ResponsiveWebAppModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Name = "";
                ViewBag.Age = 0;
            }
            return View(model);
        }
    }
}
