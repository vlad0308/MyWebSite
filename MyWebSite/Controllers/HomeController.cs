using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
