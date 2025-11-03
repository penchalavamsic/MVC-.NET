using System.Diagnostics;
using HomeController_QueryString.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeController_QueryString.Controllers
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
        //client-side management
        public IActionResult Details()
        {
            string number;
            string name;
            number=HttpContext.Request.Query["number"];
            name=HttpContext.Request.Query["name"];
            return Content("Your name is "+name+" Your Number is "+number);
        }
    }
}
