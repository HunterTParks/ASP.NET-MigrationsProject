using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GummyBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GMDbContext db = new GMDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            return View();
        }
    }

}
