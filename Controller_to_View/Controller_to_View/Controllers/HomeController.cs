using System.Diagnostics;
using Controller_to_View.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controller_to_View.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //user defined controller
        public IActionResult Details()
        {
            ViewData["Name"] = "Vamsi";
            ViewBag.course= "ASP.NET Core MVC";
            return View();
        }
    }
}
