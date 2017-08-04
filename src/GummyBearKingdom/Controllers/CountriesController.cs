using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

namespace GummyBearKingdom.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index(DbSet<Country> Countries)
        {
            return View(Countries);
        }
    }
}
