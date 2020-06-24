using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.User.Controllers
{
    [Area("User")]

    public class subCategoryDataController : Controller
    {
        private ApplicationDbContext db;


        //Constructor
        public subCategoryDataController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getsubcategoryData(int id)
        {
          var subcat=  db.SubCategories.Find(id);

            return View(subcat);
        }

        public IActionResult getProductDetails(int id)
        {
           var product = db.Products.Find(id);
            ViewBag.color = ColorTranslator.FromHtml(product.productColor);

            return View(product);
        }
    }
}
