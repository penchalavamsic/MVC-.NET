using System.Diagnostics;
using Combine_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Combine_MVC.Controllers
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
        //model binders
        public IActionResult Details(Student obj)
        {
            return View(obj);
        }

        //without model binders
        /*public IActionResult Details(IFormCollection fc)
        {
            Student obj = new Student();
            obj.stno = Convert.ToInt32(fc["stno"]);
            obj.sname = fc["sname"];
            obj.DOA = Convert.ToDateTime(fc["DOA"]);
            obj.fees = Convert.ToInt32(fc["fees"]);
            return View(obj);
        }*/
    }
}
