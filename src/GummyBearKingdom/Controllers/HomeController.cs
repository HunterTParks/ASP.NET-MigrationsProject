using Microsoft.AspNetCore.Mvc;

namespace GummyBearKingdom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
