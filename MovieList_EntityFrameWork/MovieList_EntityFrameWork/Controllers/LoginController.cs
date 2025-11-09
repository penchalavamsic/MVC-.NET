using Microsoft.AspNetCore.Mvc;

namespace MovieList_EntityFrameWork.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if(username == "admin" && password == "password")
            {
                // In a real application, use proper authentication mechanisms
                return RedirectToAction("Index", "Movies");
            }
            
            return View();
        }
    }
}
