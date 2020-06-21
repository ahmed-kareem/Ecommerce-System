using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.User.Controllers
{
    [Area("User")]
    public class HemalayaController : Controller
    {
        private readonly ApplicationDbContext context;
        public HemalayaController(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        public IActionResult Index()
        {

            var viewModel = new HomeViewModel()
            {
                products = context.Products.ToList(),
                mainCategories = context.MainCategories.ToList(),
                subCategories = context.SubCategories.ToList()
            };

            return View(viewModel);
        }
    }
}
