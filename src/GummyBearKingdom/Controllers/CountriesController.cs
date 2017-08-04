using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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

        [HttpPost]
        public IActionResult Edit(Country country)
        {
            db.Entry(country).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisCountry = db.Countries.FirstOrDefault(Country => Country.CountryId == id);
            return View(thisCountry);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisCountry = db.Countries.FirstOrDefault(Country => Country.CountryId == id);
            db.Countries.Remove(thisCountry);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
