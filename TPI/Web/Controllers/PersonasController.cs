using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TPI.Entidades;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class PersonasController : Controller
    {
        private readonly WebContext _context;

        public PersonasController(WebContext context)
        {
            _context = context;
        }

        // GET: Personas
        public async Task<IActionResult> Index()
        {
            return View(await _context.personas.ToListAsync());
        }

        // GET: Personas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.personas
                .FirstOrDefaultAsync(m => m.Dni == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Dni,Nombre,Apellido,Direccion,FechaNacimiento,Telefono")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(persona);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {
                    return View("ErrorCustom", "Ya existe una Persona registrada con ese DNI en el Sistema");
                }
            }
            return View(persona);
        }

        // GET: Personas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Dni,Direccion,Telefono")] Persona persona)
        {
            if (id != persona.Dni)
            {
                return NotFound();
            }

            try
            {
                var personaEnc = await _context.personas.FindAsync(persona.Dni);
                personaEnc.Direccion = persona.Direccion;
                personaEnc.Telefono = persona.Telefono;
                _context.personas.Update(personaEnc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(persona.Dni))
                {
                    return NotFound();
                }
                else
                {
                    return View(persona);
                    throw;
                }
            }
        }

        // GET: Personas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.personas
                .FirstOrDefaultAsync(m => m.Dni == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.personas.FindAsync(id);
            _context.personas.Remove(persona);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.personas.Any(e => e.Dni == id);
        }
    }
}
