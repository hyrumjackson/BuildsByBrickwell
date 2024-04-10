using System.Diagnostics;
using BuildsByBrickwell.Models;
using BuildsByBrickwell.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BuildsByBrickwell.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }
    }
}
