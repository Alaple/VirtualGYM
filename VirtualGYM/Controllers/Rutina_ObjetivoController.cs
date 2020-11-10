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
    public class Rutina_ObjetivoController : Controller
    {
        private readonly DataBaseContext _context;

        public Rutina_ObjetivoController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Rutina_Objetivo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rutinas_Objetivos.ToListAsync());
        }

        // GET: Rutina_Objetivo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rutina_Objetivo = await _context.Rutinas_Objetivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rutina_Objetivo == null)
            {
                return NotFound();
            }

            return View(rutina_Objetivo);
        }

        // GET: Rutina_Objetivo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rutina_Objetivo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Rutina_Objetivo rutina_Objetivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rutina_Objetivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rutina_Objetivo);
        }

        // GET: Rutina_Objetivo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rutina_Objetivo = await _context.Rutinas_Objetivos.FindAsync(id);
            if (rutina_Objetivo == null)
            {
                return NotFound();
            }
            return View(rutina_Objetivo);
        }

        // POST: Rutina_Objetivo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Rutina_Objetivo rutina_Objetivo)
        {
            if (id != rutina_Objetivo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rutina_Objetivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Rutina_ObjetivoExists(rutina_Objetivo.Id))
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
            return View(rutina_Objetivo);
        }

        // GET: Rutina_Objetivo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rutina_Objetivo = await _context.Rutinas_Objetivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rutina_Objetivo == null)
            {
                return NotFound();
            }

            return View(rutina_Objetivo);
        }

        // POST: Rutina_Objetivo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rutina_Objetivo = await _context.Rutinas_Objetivos.FindAsync(id);
            _context.Rutinas_Objetivos.Remove(rutina_Objetivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Rutina_ObjetivoExists(int id)
        {
            return _context.Rutinas_Objetivos.Any(e => e.Id == id);
        }
    }
}
