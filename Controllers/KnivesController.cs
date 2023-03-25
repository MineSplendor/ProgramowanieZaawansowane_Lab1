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
    public class KnivesController : Controller
    {
        private readonly MvcKnifeContext _context;

        public KnivesController(MvcKnifeContext context)
        {
            _context = context;
        }

        // GET: Knives
        public async Task<IActionResult> Index()
        {
            return View(await _context.Knife.ToListAsync());
        }

        // GET: Knives/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knife = await _context.Knife
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knife == null)
            {
                return NotFound();
            }

            return View(knife);
        }

        // GET: Knives/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Knives/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Material,Sharpness,Length,Weight")] Knife knife)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knife);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(knife);
        }

        // GET: Knives/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knife = await _context.Knife.FindAsync(id);
            if (knife == null)
            {
                return NotFound();
            }
            return View(knife);
        }

        // POST: Knives/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Material,Sharpness,Length,Weight")] Knife knife)
        {
            if (id != knife.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knife);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnifeExists(knife.Id))
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
            return View(knife);
        }

        // GET: Knives/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knife = await _context.Knife
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knife == null)
            {
                return NotFound();
            }

            return View(knife);
        }

        // POST: Knives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var knife = await _context.Knife.FindAsync(id);
            _context.Knife.Remove(knife);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnifeExists(int id)
        {
            return _context.Knife.Any(e => e.Id == id);
        }
    }
}
