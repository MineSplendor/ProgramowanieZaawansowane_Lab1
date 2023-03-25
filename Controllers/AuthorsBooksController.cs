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
    public class AuthorsBooksController : Controller
    {
        private readonly MvcAuthorsBookContext _context;

        public AuthorsBooksController(MvcAuthorsBookContext context)
        {
            _context = context;
        }

        // GET: AuthorsBooks
        public async Task<IActionResult> Index()
        {
            return View(await _context.AuthorsBook.ToListAsync());
        }

        // GET: AuthorsBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorsBook = await _context.AuthorsBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authorsBook == null)
            {
                return NotFound();
            }

            return View(authorsBook);
        }

        // GET: AuthorsBooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AuthorsBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pages,ReleaseYear,Genre,Rate,Price")] AuthorsBook authorsBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authorsBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(authorsBook);
        }

        // GET: AuthorsBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorsBook = await _context.AuthorsBook.FindAsync(id);
            if (authorsBook == null)
            {
                return NotFound();
            }
            return View(authorsBook);
        }

        // POST: AuthorsBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pages,ReleaseYear,Genre,Rate,Price")] AuthorsBook authorsBook)
        {
            if (id != authorsBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(authorsBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorsBookExists(authorsBook.Id))
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
            return View(authorsBook);
        }

        // GET: AuthorsBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorsBook = await _context.AuthorsBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authorsBook == null)
            {
                return NotFound();
            }

            return View(authorsBook);
        }

        // POST: AuthorsBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorsBook = await _context.AuthorsBook.FindAsync(id);
            _context.AuthorsBook.Remove(authorsBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorsBookExists(int id)
        {
            return _context.AuthorsBook.Any(e => e.Id == id);
        }
    }
}
