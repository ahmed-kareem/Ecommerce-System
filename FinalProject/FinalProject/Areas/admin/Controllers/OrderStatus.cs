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
    public class OrderStatus : Controller
    {
        private ApplicationDbContext db;

        public OrderStatus(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<orderstatus> orderstatuses = db.orderstatuses.ToList();
            return View(orderstatuses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(orderstatus neworderstatus)
        {
            orderstatus orderstatus = new orderstatus() { status = neworderstatus.status };
            db.orderstatuses.Add(orderstatus);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            orderstatus requiredrow = db.orderstatuses.Find(id);
            db.orderstatuses.Remove(requiredrow);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
