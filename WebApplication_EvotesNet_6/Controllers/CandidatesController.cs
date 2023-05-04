using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication_EvotesNet_6.Data;
using WebApplication_EvotesNet_6.Models;

namespace WebApplication_EvotesNet_6.Controllers
{
    [Authorize]
    public class CandidatesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public CandidatesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }
    
        // GET: Candidates
        public async Task<IActionResult> Index()
        {
              var Candidates = mapper.Map<List<CandidatesVM>>(await _context.Candidates.ToListAsync());
              return View(Candidates);
        }

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Candidates == null)
            {
                return NotFound();
            }

            var candidates = await _context.Candidates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidates == null)
            {
                return NotFound();
            }

            return View(candidates);
        }
        [Authorize(Roles = "Admin")]
        // GET: Candidates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candidates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Constituency,Id")] Candidates candidates)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candidates);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candidates);
        }
        [Authorize(Roles = "Admin")]
        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Candidates == null)
            {
                return NotFound();
            }

            var candidates = await _context.Candidates.FindAsync(id);
            if (candidates == null)
            {
                return NotFound();
            }
            return View(candidates);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("FirstName,LastName,Constituency,Id")] Candidates candidates)
        {
            if (id != candidates.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidates);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidatesExists(candidates.Id))
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
            return View(candidates);
        }
        [Authorize(Roles = "Admin")]
        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Candidates == null)
            {
                return NotFound();
            }

            var candidates = await _context.Candidates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidates == null)
            {
                return NotFound();
            }

            return View(candidates);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Candidates == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Candidates'  is null.");
            }
            var candidates = await _context.Candidates.FindAsync(id);
            if (candidates != null)
            {
                _context.Candidates.Remove(candidates);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidatesExists(int id)
        {
          return (_context.Candidates?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
