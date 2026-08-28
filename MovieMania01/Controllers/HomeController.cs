using Microsoft.AspNetCore.Mvc;

namespace MovieMania01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
