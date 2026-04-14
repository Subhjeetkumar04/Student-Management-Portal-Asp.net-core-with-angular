using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
        public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"]="Index";
            return View();
        }

         public IActionResult Name(int id)
        {
            ViewData[index: "Title"]="Name";
            return View();
        }
    }
}