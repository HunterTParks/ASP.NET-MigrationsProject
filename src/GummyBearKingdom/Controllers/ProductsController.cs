﻿using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using GummyBearKingdom.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace GummyBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GMDbContext db = new GMDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == id);
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            return View(thisProduct);
        }

        public IActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name").ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == id);
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(Product => Product.ProductId == id);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
