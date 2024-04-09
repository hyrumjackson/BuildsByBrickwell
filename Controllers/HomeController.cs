using System.Diagnostics;
using BuildsByBrickwell.Models;
using BuildsByBrickwell.Models.ViewModels;
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

        public IActionResult Products(int pageNum, string? productType)
        {
            int pageSize = 40;

            var blah = new ProductsListViewModel
            {
                Products = _context.Products
                    .Where(x => x.Category == productType || productType == "Products")
                    .OrderBy(x => x.Name)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = productType == null ? _context.Products.Count() : _context.Products.Where(x => x.Category == productType).Count(),
                },

                CurrentProductType = productType
            };

            return View(blah);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult OrderStatus()
        {
            return View();
        }

        public IActionResult Details(string Order)
        {
            var CurrentOrder = Order;
            return View(CurrentOrder);
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
