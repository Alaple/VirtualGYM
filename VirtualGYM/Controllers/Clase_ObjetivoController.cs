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
    public class Clase_ObjetivoController : Controller
    {
        private readonly DataBaseContext _context;

        public Clase_ObjetivoController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Clase_Objetivo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clases_Objetivos.ToListAsync());
        }

        // GET: Clase_Objetivo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clase_Objetivo = await _context.Clases_Objetivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clase_Objetivo == null)
            {
                return NotFound();
            }

            return View(clase_Objetivo);
        }

        // GET: Clase_Objetivo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clase_Objetivo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Clase_Objetivo clase_Objetivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clase_Objetivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clase_Objetivo);
        }

        // GET: Clase_Objetivo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clase_Objetivo = await _context.Clases_Objetivos.FindAsync(id);
            if (clase_Objetivo == null)
            {
                return NotFound();
            }
            return View(clase_Objetivo);
        }

        // POST: Clase_Objetivo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Clase_Objetivo clase_Objetivo)
        {
            if (id != clase_Objetivo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clase_Objetivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Clase_ObjetivoExists(clase_Objetivo.Id))
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
            return View(clase_Objetivo);
        }

        // GET: Clase_Objetivo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clase_Objetivo = await _context.Clases_Objetivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clase_Objetivo == null)
            {
                return NotFound();
            }

            return View(clase_Objetivo);
        }

        // POST: Clase_Objetivo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clase_Objetivo = await _context.Clases_Objetivos.FindAsync(id);
            _context.Clases_Objetivos.Remove(clase_Objetivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Clase_ObjetivoExists(int id)
        {
            return _context.Clases_Objetivos.Any(e => e.Id == id);
        }
    }
}
