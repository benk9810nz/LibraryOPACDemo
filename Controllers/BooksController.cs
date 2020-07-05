using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LIbraryManagementSytem.Data;
using LIbraryManagementSytem.Models;
using Microsoft.AspNetCore.Authorization;

namespace LIbraryManagementSytem.Controllers
{
    public class BooksController : Controller
    {
        private readonly LIbraryManagementSytemContext _context;

        public BooksController(LIbraryManagementSytemContext context)
        {
            _context = context;
        }

        // GET: Books
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var lIbraryManagementSytemContext = _context.BOOKS.Include(b => b.Genre).Include(b => b.Publisher);
            return View(await lIbraryManagementSytemContext.ToListAsync());
        }

        // GET: Books/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var viewModel = new BookDetailsModel();
            viewModel.Books = await _context.BOOKS
                .Include(b => b.Genre)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.BookID == id);

            viewModel.BookCopies = await _context.BOOKCOPIES
                .Where(bc => bc.BookID == id)
                .Include(bc => bc.Retailer)
                .ToListAsync(); //Get Book Copies List


            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: Books/Create
        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Create()
        {
            ViewData["GenreID"] = new SelectList(_context.GENRES, "GenreID", "Name");
            ViewData["PublisherID"] = new SelectList(_context.PUBLISHERS, "PublisherID", "Name");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Create([Bind("BookID,Name,AuthorName,PublicationDate,PublisherID,GenreID,Description")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenreID"] = new SelectList(_context.GENRES, "GenreID", "Name", book.GenreID);
            ViewData["PublisherID"] = new SelectList(_context.PUBLISHERS, "PublisherID", "Name", book.PublisherID);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.BOOKS.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["GenreID"] = new SelectList(_context.GENRES, "GenreID", "Name", book.GenreID);
            ViewData["PublisherID"] = new SelectList(_context.PUBLISHERS, "PublisherID", "Name", book.PublisherID);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("BookID,Name,AuthorName,PublicationDate,PublisherID,GenreID,Description")] Book book)
        {
            if (id != book.BookID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookID))
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
            ViewData["GenreID"] = new SelectList(_context.GENRES, "GenreID", "Name", book.GenreID);
            ViewData["PublisherID"] = new SelectList(_context.PUBLISHERS, "PublisherID", "Name", book.PublisherID);
            return View(book);
        }

        // GET: Books/Delete/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.BOOKS
                .Include(b => b.Genre)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.BookID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.BOOKS.FindAsync(id);
            _context.BOOKS.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.BOOKS.Any(e => e.BookID == id);
        }
    }
}
