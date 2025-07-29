using Microsoft.AspNetCore.Mvc;

namespace Day10_DemoWebapp_Hello_world.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
