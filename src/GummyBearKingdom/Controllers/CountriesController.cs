using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [HttpPost]
        public IActionResult Create(Country country)
        {
            db.Countries.Add(country);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisCountry = db.Countries.FirstOrDefault(Country => Country.CountryId == id);
            ViewBag.CountryId = new SelectList(db.Countries, "Name");
            return View(thisCountry);
        }
    }
}
