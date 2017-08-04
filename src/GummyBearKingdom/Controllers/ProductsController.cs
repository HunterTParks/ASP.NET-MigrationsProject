using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBearKingdom.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummyBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GMDbContext db = new GMDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }

    public IActionResult Create()
    {
        return View();
    }
}
