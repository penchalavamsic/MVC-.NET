using System.Diagnostics;
using CricketData.Models;
using Microsoft.AspNetCore.Mvc;

namespace CricketData.Controllers
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
        //controller for Cricket player details
        public IActionResult PlayerDetails(IFormCollection fc)
        {  //form collection to collect data from form
            Cricket crk=new Cricket();
            crk.id=Convert.ToInt32(fc["id"]);
            crk.name=fc["name"];
            crk.country=fc["country"];
            crk.runs=Convert.ToInt32(fc["runs"]);
            crk.GameDay=Convert.ToDateTime(fc["GameDay"]);
                return View(crk);


        }

    }
}
