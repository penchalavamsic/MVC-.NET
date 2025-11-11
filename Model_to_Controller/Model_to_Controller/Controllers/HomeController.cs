using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Model_to_Controller.Models;

namespace Model_to_Controller.Controllers
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
        public IActionResult Address(Address obj) //model binding
        {
            Address1(obj); //calling two methods with singleAction method
            Address2(obj);
            return View(obj);
        }
        public void Address1(Address obj)
        {

        }
        public void Address2(Address obj)
        {
        }
    }
}
