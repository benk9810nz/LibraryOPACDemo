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
    public class BookCopiesController : Controller
    {
        private readonly LIbraryManagementSytemContext _context;

        public BookCopiesController(LIbraryManagementSytemContext context)
        {
            _context = context;
        }

        // GET: BookCopies
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var lIbraryManagementSytem2Context = _context.BOOKCOPIES.Include(b => b.Book).Include(b => b.Retailer);
            return View(await lIbraryManagementSytem2Context.ToListAsync());
        }

        [Authorize]
        // GET: BookCopies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookCopies = await _context.BOOKCOPIES
                .Include(b => b.Book)
                .Include(b => b.Retailer)
                .FirstOrDefaultAsync(m => m.BookCopiesID == id);
            if (bookCopies == null)
            {
                return NotFound();
            }

            return View(bookCopies);
        }
        [Authorize(Roles = "Admin,Employee")]
        //GET: BookCopies/Create
        public IActionResult Create()
        {
            ViewData["BookID"] = new SelectList(_context.Set<Book>(), "BookID", "Name");
            ViewData["RetailerID"] = new SelectList(_context.Set<Retailer>(), "RetailerID", "Name");
            return View();
        }

        // POST: BookCopies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookCopiesID,BookBarcode,BookID,RetailerID,PurchasePrice,RFID,UpdatedDateTime")] BookCopies bookCopies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookCopies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookID"] = new SelectList(_context.Set<Book>(), "BookID", "Name", bookCopies.BookID);
            ViewData["RetailerID"] = new SelectList(_context.Set<Retailer>(), "RetailerID", "Name", bookCopies.RetailerID);
            return View(bookCopies);
        }

        [Authorize(Roles = "Admin,Employee")]
        // GET: BookCopies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookCopies = await _context.BOOKCOPIES.FindAsync(id);
            if (bookCopies == null)
            {
                return NotFound();
            }
            ViewData["BookID"] = new SelectList(_context.Set<Book>(), "BookID", "Name", bookCopies.BookID);
            ViewData["RetailerID"] = new SelectList(_context.Set<Retailer>(), "RetailerID", "Name", bookCopies.RetailerID);
            return View(bookCopies);
        }

        // POST: BookCopies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin,Employee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookCopiesID,BookBarcode,BookID,RetailerID,PurchasePrice,RFID,UpdatedDateTime")] BookCopies bookCopies)
        {
            if (id != bookCopies.BookCopiesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookCopies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookCopiesExists(bookCopies.BookCopiesID))
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
            ViewData["BookID"] = new SelectList(_context.Set<Book>(), "BookID", "Name", bookCopies.BookID);
            ViewData["RetailerID"] = new SelectList(_context.Set<Retailer>(), "RetailerID", "Name", bookCopies.RetailerID);
            return View(bookCopies);
        }

        [Authorize(Roles = "Admin,Employee")]
        // GET: BookCopies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookCopies = await _context.BOOKCOPIES
                .Include(b => b.Book)
                .Include(b => b.Retailer)
                .FirstOrDefaultAsync(m => m.BookCopiesID == id);
            if (bookCopies == null)
            {
                return NotFound();
            }

            return View(bookCopies);
        }
       
        // POST: BookCopies/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin,Employee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookCopies = await _context.BOOKCOPIES.FindAsync(id);
            _context.BOOKCOPIES.Remove(bookCopies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookCopiesExists(int id)
        {
            return _context.BOOKCOPIES.Any(e => e.BookCopiesID == id);
        }
    }
}
