using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.User.Controllers
{
    [Area("User")]
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext context;
        public ShopController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult ShopProducts(int SubCategoryId)
        {
            //var subCategory = context.SubCategories.Find(SubCategoryId);
            var products = context.Products.Where(p=>p.subCategoryId == SubCategoryId);

            return View(products);
        }
    }
}
