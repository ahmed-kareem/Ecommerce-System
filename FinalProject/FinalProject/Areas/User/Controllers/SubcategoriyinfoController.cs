using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Area("User")]

    public class SubcategoriyinfoController : Controller
    {
        private ApplicationDbContext db;

        public SubcategoriyinfoController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var categories = db.MainCategories.Take(3);
            //var subcat = db.SubCategories.Where(x => categories.Any(xx=>xx.mainCategoryId==x.mainCategoryId)).Take(10);
            return View(categories);
        }
        //public JsonResult search(string Prefix)
        //{
        //    var productlist = db.Products.Select(x => x.productName).ToList();
        //    var result = (from N in productlist
        //                  where N.productName.Contains(Prefix)
        //                  select new { N.productName });
        //    return Json(result.ToArray());
        //}

    }
}
