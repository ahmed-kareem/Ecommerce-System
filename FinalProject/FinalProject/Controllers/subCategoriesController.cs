//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using FinalProject.Data;
//using FinalProject.Models;

//namespace FinalProject.Controllers
//{
//    public class subCategoriesController : Controller
//    {
//        private readonly FinalProjectContext _context;

//        public subCategoriesController(FinalProjectContext context)
//        {
//            _context = context;
//        }

//        // GET: subCategories
//        public async Task<IActionResult> Index()
//        {
//            var finalProjectContext = _context.subCategory.Include(s => s.MainCategory);
//            return View(await finalProjectContext.ToListAsync());
//        }

//        // GET: subCategories/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var subCategory = await _context.subCategory
//                .Include(s => s.MainCategory)
//                .FirstOrDefaultAsync(m => m.subCategoryId == id);
//            if (subCategory == null)
//            {
//                return NotFound();
//            }

//            return View(subCategory);
//        }

//        // GET: subCategories/Create
//        public IActionResult Create()
//        {
//            ViewData["mainCategoryId"] = new SelectList(_context.Set<mainCategory>(), "mainCategoryId", "mainCategoryName");
//            return View();
//        }

//        // POST: subCategories/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("subCategoryId,subCategoryName,subCategoryPhoto,mainCategoryId")] subCategory subCategory)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(subCategory);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["mainCategoryId"] = new SelectList(_context.Set<mainCategory>(), "mainCategoryId", "mainCategoryName", subCategory.mainCategoryId);
//            return View(subCategory);
//        }

//        // GET: subCategories/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var subCategory = await _context.subCategory.FindAsync(id);
//            if (subCategory == null)
//            {
//                return NotFound();
//            }
//            ViewData["mainCategoryId"] = new SelectList(_context.Set<mainCategory>(), "mainCategoryId", "mainCategoryName", subCategory.mainCategoryId);
//            return View(subCategory);
//        }

//        // POST: subCategories/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("subCategoryId,subCategoryName,subCategoryPhoto,mainCategoryId")] subCategory subCategory)
//        {
//            if (id != subCategory.subCategoryId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(subCategory);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!subCategoryExists(subCategory.subCategoryId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["mainCategoryId"] = new SelectList(_context.Set<mainCategory>(), "mainCategoryId", "mainCategoryName", subCategory.mainCategoryId);
//            return View(subCategory);
//        }

//        // GET: subCategories/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var subCategory = await _context.subCategory
//                .Include(s => s.MainCategory)
//                .FirstOrDefaultAsync(m => m.subCategoryId == id);
//            if (subCategory == null)
//            {
//                return NotFound();
//            }

//            return View(subCategory);
//        }

//        // POST: subCategories/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var subCategory = await _context.subCategory.FindAsync(id);
//            _context.subCategory.Remove(subCategory);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool subCategoryExists(int id)
//        {
//            return _context.subCategory.Any(e => e.subCategoryId == id);
//        }
//    }
//}
