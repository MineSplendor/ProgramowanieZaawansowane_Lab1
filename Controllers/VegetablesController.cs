using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson1.Data;
using AdvancedProgramming_Lesson1.Models;

namespace AdvancedProgramming_Lesson1.Controllers
{
    public class VegetablesController : Controller
    {
        private readonly MvcVegetableContext _context;

        public VegetablesController(MvcVegetableContext context)
        {
            _context = context;
        }

        // GET: Vegetables
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vegetable.ToListAsync());
        }

        // GET: Vegetables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vegetable == null)
            {
                return NotFound();
            }

            return View(vegetable);
        }

        // GET: Vegetables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vegetables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,ExpirationDate,Weight,Sugar,Price")] Vegetable vegetable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vegetable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vegetable);
        }

        // GET: Vegetables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetable.FindAsync(id);
            if (vegetable == null)
            {
                return NotFound();
            }
            return View(vegetable);
        }

        // POST: Vegetables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,ExpirationDate,Weight,Sugar,Price")] Vegetable vegetable)
        {
            if (id != vegetable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vegetable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VegetableExists(vegetable.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vegetable);
        }

        // GET: Vegetables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vegetable == null)
            {
                return NotFound();
            }

            return View(vegetable);
        }

        // POST: Vegetables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vegetable = await _context.Vegetable.FindAsync(id);
            _context.Vegetable.Remove(vegetable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VegetableExists(int id)
        {
            return _context.Vegetable.Any(e => e.Id == id);
        }
    }
}
