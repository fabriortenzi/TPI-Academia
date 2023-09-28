using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcademiaWeb.Data;
using AcademiaWeb.Models;

namespace AcademiaWeb.Controllers
{
    public class ComisionsController : Controller
    {
        private readonly AcademiaWebContext _context;

        public ComisionsController(AcademiaWebContext context)
        {
            _context = context;
        }

        // GET: Comisions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comision.ToListAsync());
        }

        // GET: Comisions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comision = await _context.Comision
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comision == null)
            {
                return NotFound();
            }

            return View(comision);
        }

        // GET: Comisions/Create
        public async Task<IActionResult> Create()
        {

            var especialidades = await _context.ObtenerEspecialidadesAsync();
            ViewBag.Especialidades = new SelectList(especialidades, "Id", "Descripcion");

            return View();
        }

        // POST: Comisions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NroComision")] Comision comision, [Bind("idEspecialidad")] int idEspecialidad)
        {
            if (ModelState.IsValid)
            {
                var especialidad = await _context.Especialidad.FindAsync(idEspecialidad);
                comision.Especialidad = especialidad;
                _context.Add(comision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comision);
        }

        // GET: Comisions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comision = await _context.Comision.FindAsync(id);
            if (comision == null)
            {
                return NotFound();
            }
            return View(comision);
        }

        // POST: Comisions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NroComision")] Comision comision)
        {
            if (id != comision.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComisionExists(comision.Id))
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
            return View(comision);
        }

        // GET: Comisions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comision = await _context.Comision
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comision == null)
            {
                return NotFound();
            }

            return View(comision);
        }

        // POST: Comisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comision = await _context.Comision.FindAsync(id);
            _context.Comision.Remove(comision);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComisionExists(int id)
        {
            return _context.Comision.Any(e => e.Id == id);
        }
    }
}
