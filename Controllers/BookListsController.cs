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
    public class BookListsController : Controller
    {
        private readonly MvcBookListContext _context;

        public BookListsController(MvcBookListContext context)
        {
            _context = context;
        }

        // GET: BookLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookList.ToListAsync());
        }

        // GET: BookLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookList = await _context.BookList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookList == null)
            {
                return NotFound();
            }

            return View(bookList);
        }

        // GET: BookLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pages,Release,Circulation,Rate,Price")] BookList bookList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookList);
        }

        // GET: BookLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookList = await _context.BookList.FindAsync(id);
            if (bookList == null)
            {
                return NotFound();
            }
            return View(bookList);
        }

        // POST: BookLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pages,Release,Circulation,Rate,Price")] BookList bookList)
        {
            if (id != bookList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookListExists(bookList.Id))
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
            return View(bookList);
        }

        // GET: BookLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookList = await _context.BookList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookList == null)
            {
                return NotFound();
            }

            return View(bookList);
        }

        // POST: BookLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookList = await _context.BookList.FindAsync(id);
            _context.BookList.Remove(bookList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookListExists(int id)
        {
            return _context.BookList.Any(e => e.Id == id);
        }
    }
}
