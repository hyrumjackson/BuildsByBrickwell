using System.Diagnostics;
using BuildsByBrickwell.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuildsByBrickwell.Controllers
{
    public class HomeController : Controller
    {
        private IntexProjectContext _context;

        public HomeController(IntexProjectContext temp)
        {
            _context = temp;    
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Testing()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public IActionResult Login()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
