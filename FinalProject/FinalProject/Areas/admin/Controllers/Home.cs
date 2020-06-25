using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.admin.Controllers
{
    [Area("admin")]
    public class Home : Controller
    {

        private ApplicationDbContext db;

        public Home(ApplicationDbContext db)
        {
            this.db = db;
        }


        public IActionResult Login(string name , string password)
        {
            if(name == "admin" && password == "admin")
            {
               return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Index()
        {
            List<order> orders = db.orders.Where(a => a.orderStatus == "Open").ToList();
            return View(orders);
        }

        public IActionResult pending()
        {
            List<order> orders = db.orders.Where(a => a.orderStatus == "Pending").ToList();
            return View(orders);
        }
    }
}
