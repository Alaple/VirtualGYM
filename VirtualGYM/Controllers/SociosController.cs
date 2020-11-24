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
    public class SociosController : Controller
    {
        private readonly DataBaseContext _context;

        public SociosController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Socios
        public async Task<IActionResult> Index()
        {
            ViewBag.clases = await _context.Clases.ToListAsync();
            return View(await _context.Socios.ToListAsync());
        }

        // GET: Socios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socio == null)
            {
                return NotFound();
            }

            return View(socio);
        }

        // GET: Socios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Socios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Usuario,Nombre,Apellido,Clave,Sexo,Edad,Peso,Altura")] Socio socio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socio);
        }

        // GET: Socios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios.FindAsync(id);
            if (socio == null)
            {
                return NotFound();
            }
            return View(socio);
        }

        // POST: Socios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Usuario,Nombre,Apellido,Clave,Sexo,Edad,Peso,Altura")] Socio socio)
        {
            if (id != socio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocioExists(socio.Id))
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
            return View(socio);
        }

        // GET: Socios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socio = await _context.Socios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socio == null)
            {
                return NotFound();
            }

            return View(socio);
        }

        // POST: Socios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socio = await _context.Socios.FindAsync(id);
            _context.Socios.Remove(socio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocioExists(int id)
        {
            return _context.Socios.Any(e => e.Id == id);
        }

        private async Task<IActionResult> ActualizarEsfuerzo()
        {
            int idSocio = 1; int esfuerzo = 10;
            var socio = _context.Socios.Where(x => x.Id == idSocio).FirstOrDefault<Socio>(); // BUSCAMOS EL SOCIO
            var objetivo = _context.Objetivos.Where(x => x.Id == socio.IdObjetivo).FirstOrDefault<Objetivo>(); // BUSCAMOS SU OBJETIVO
            objetivo.EsfuerzoTotal =- esfuerzo;
            await _context.SaveChangesAsync();
            Console.WriteLine("ENTRE A LA FUNCION");
            return View("Index");
        }
    }
}
