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
    public class RetailersController : Controller
    {
        private readonly LIbraryManagementSytemContext _context;

        public RetailersController(LIbraryManagementSytemContext context)
        {
            _context = context;
        }

        // GET: Retailers
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.RETAILERS.ToListAsync());
        }

        // GET: Retailers/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retailer = await _context.RETAILERS
                .FirstOrDefaultAsync(m => m.RetailerID == id);
            if (retailer == null)
            {
                return NotFound();
            }

            return View(retailer);
        }

        // GET: Retailers/Create
        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Retailers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Create([Bind("RetailerID,Name,Address1,Address2,City,PhoneNumber,WebsiteURL,EmailAddress")] Retailer retailer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(retailer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(retailer);
        }

        // GET: Retailers/Edit/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retailer = await _context.RETAILERS.FindAsync(id);
            if (retailer == null)
            {
                return NotFound();
            }
            return View(retailer);
        }

        // POST: Retailers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("RetailerID,Name,Address1,Address2,City,PhoneNumber,WebsiteURL,EmailAddress")] Retailer retailer)
        {
            if (id != retailer.RetailerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(retailer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RetailerExists(retailer.RetailerID))
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
            return View(retailer);
        }

        // GET: Retailers/Delete/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retailer = await _context.RETAILERS
                .FirstOrDefaultAsync(m => m.RetailerID == id);
            if (retailer == null)
            {
                return NotFound();
            }

            return View(retailer);
        }

        // POST: Retailers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var retailer = await _context.RETAILERS.FindAsync(id);
            _context.RETAILERS.Remove(retailer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RetailerExists(int id)
        {
            return _context.RETAILERS.Any(e => e.RetailerID == id);
        }
    }
}
