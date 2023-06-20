﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlanAhead.Data;
using PlanAhead.Models;

namespace PlanAhead.Controllers
{
    public class HouseholdsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HouseholdsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Households
        public async Task<IActionResult> Index()
        {
              return _context.Household != null ? 
                          View(await _context.Household.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Household'  is null.");
        }

        // GET: Households/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Household == null)
            {
                return NotFound();
            }

            var household = await _context.Household
                .FirstOrDefaultAsync(m => m.Id == id);
            if (household == null)
            {
                return NotFound();
            }

            return View(household);
        }

        // GET: Households/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Households/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Household household)
        {
            if (ModelState.IsValid)
            {
                _context.Add(household);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(household);
        }

        // GET: Households/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Household == null)
            {
                return NotFound();
            }

            var household = await _context.Household.FindAsync(id);
            if (household == null)
            {
                return NotFound();
            }
            return View(household);
        }

        // POST: Households/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Household household)
        {
            if (id != household.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(household);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HouseholdExists(household.Id))
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
            return View(household);
        }

        // GET: Households/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Household == null)
            {
                return NotFound();
            }

            var household = await _context.Household
                .FirstOrDefaultAsync(m => m.Id == id);
            if (household == null)
            {
                return NotFound();
            }

            return View(household);
        }

        // POST: Households/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Household == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Household'  is null.");
            }
            var household = await _context.Household.FindAsync(id);
            if (household != null)
            {
                _context.Household.Remove(household);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HouseholdExists(int id)
        {
          return (_context.Household?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
