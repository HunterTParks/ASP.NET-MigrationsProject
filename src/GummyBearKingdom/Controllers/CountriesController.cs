using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GummyBearKingdom.Controllers
{
    public class CountriesController : Controller
    {
        private GMDbContext db = new GMDbContext();
        public IActionResult Index()
        {
            return View(db.Countries.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
