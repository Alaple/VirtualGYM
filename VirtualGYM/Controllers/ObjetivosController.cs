using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VirtualGYM.Context;
using VirtualGYM.Models;

namespace VirtualGYM.Controllers
{
    public class ObjetivosController : Controller
    {
        private readonly DataBaseContext _context;

        public ObjetivosController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Objetivos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Objetivos.ToListAsync());
        }

        // GET: Objetivos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetivo = await _context.Objetivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (objetivo == null)
            {
                return NotFound();
            }

            return View(objetivo);
        }

        // GET: Objetivos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Objetivos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,EsfuerzoTotal")] Objetivo objetivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objetivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(objetivo);
        }

        // GET: Objetivos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetivo = await _context.Objetivos.FindAsync(id);
            if (objetivo == null)
            {
                return NotFound();
            }
            return View(objetivo);
        }

        // POST: Objetivos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,EsfuerzoTotal")] Objetivo objetivo)
        {
            if (id != objetivo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objetivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjetivoExists(objetivo.Id))
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
            return View(objetivo);
        }

        // GET: Objetivos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetivo = await _context.Objetivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (objetivo == null)
            {
                return NotFound();
            }

            return View(objetivo);
        }

        // POST: Objetivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var objetivo = await _context.Objetivos.FindAsync(id);
            _context.Objetivos.Remove(objetivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObjetivoExists(int id)
        {
            return _context.Objetivos.Any(e => e.Id == id);
        }
    }
}
