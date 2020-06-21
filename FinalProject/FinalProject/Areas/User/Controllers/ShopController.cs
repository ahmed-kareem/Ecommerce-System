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
            //check first if no id is passed 
            if (SubCategoryId == 0) 
            {
                var prod = context.Products.ToList();
                return View(prod);
            }
            //var subCategory = context.SubCategories.Find(SubCategoryId);
            var products = context.Products.Where(p=>p.subCategoryId == SubCategoryId);

            return View(products);
        }
        //filter products by price
        public IActionResult FilterByPrice(int priceRange)
        {
            //get products with price less than or equal to filtering price
            var FilteredProducts = context.Products.Where(p => p.productPrice <= priceRange).ToList();
            return PartialView(FilteredProducts);
        }

        //product details page
        public IActionResult ProductDetails(int productId)
        {
            var product = context.Products.Find(productId);
            return View(product);
        }
    }
}
