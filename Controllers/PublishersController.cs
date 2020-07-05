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
    public class PublishersController : Controller
    {
        private readonly LIbraryManagementSytemContext _context;

        public PublishersController(LIbraryManagementSytemContext context)
        {
            _context = context;
        }

        // GET: Publishers
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.PUBLISHERS.ToListAsync());
        }

        // GET: Publishers/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.PUBLISHERS
                .FirstOrDefaultAsync(m => m.PublisherID == id);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // GET: Publishers/Create
        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publishers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Create([Bind("PublisherID,Name,Address1,Address2,Suburb,City,Postcode,PhoneNumber,WebsiteURL")] Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(publisher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        // GET: Publishers/Edit/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.PUBLISHERS.FindAsync(id);
            if (publisher == null)
            {
                return NotFound();
            }
            return View(publisher);
        }

        // POST: Publishers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("PublisherID,Name,Address1,Address2,Suburb,City,Postcode,PhoneNumber,WebsiteURL")] Publisher publisher)
        {
            if (id != publisher.PublisherID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(publisher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PublisherExists(publisher.PublisherID))
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
            return View(publisher);
        }

        // GET: Publishers/Delete/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.PUBLISHERS
                .FirstOrDefaultAsync(m => m.PublisherID == id);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }

        // POST: Publishers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisher = await _context.PUBLISHERS.FindAsync(id);
            _context.PUBLISHERS.Remove(publisher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PublisherExists(int id)
        {
            return _context.PUBLISHERS.Any(e => e.PublisherID == id);
        }
    }
}
