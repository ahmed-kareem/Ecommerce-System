using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Areas.admin.Controllers
{
    [Area("admin")]
    public class subCat : Controller
    {
        private ApplicationDbContext db;
        private IWebHostEnvironment webhostenviroment;
        public subCat(ApplicationDbContext db , IWebHostEnvironment webhostenviroment)
        {
            this.db = db;
            this.webhostenviroment = webhostenviroment;
        }




        public IActionResult Index()
        {
            List<subCategory> allsubcategories = db.SubCategories.ToList();
            return View(allsubcategories);
        }



        [HttpGet]
        public IActionResult Create()
        {
            List<mainCategory> allmaincategories = db.MainCategories.ToList();
            SelectList maincategoriesforddl = new SelectList(allmaincategories, "mainCatId", "mainCatName");
            ViewBag.categories = maincategoriesforddl;

            return View();
        }



        [HttpPost]
        public IActionResult Create(subCategory newsubcategory , IFormFile subcategoryphoto)
        {
            if (ModelState.IsValid)
            { 
                if (subcategoryphoto != null)
                {
                    string wwwrootpath = webhostenviroment.WebRootPath;
                    string photoname = $"{Guid.NewGuid().ToString()}_{subcategoryphoto.FileName}";
                    string requiredpath = $"{wwwrootpath}/photos/{photoname}";
                    subcategoryphoto.CopyTo(new FileStream(requiredpath, FileMode.Create));

                    subCategory newsubcategoryobject = new subCategory { subCategoryName = newsubcategory.subCategoryName, subCategoryPhoto = photoname};
                    db.SubCategories.Add(newsubcategoryobject);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    subCategory newsubcategoryobject = new subCategory { subCategoryName = newsubcategory.subCategoryName, MainCategory = newsubcategory.MainCategory };
                    db.SubCategories.Add(newsubcategoryobject);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Create");
            }

        }
    }
}
