using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Person.Data;
using Person.Models;

namespace Person.Controllers
{
    public class EntitiesModelsController : Controller
    {
        private readonly PersonContext _context;

        public EntitiesModelsController(PersonContext context)
        {
            _context = context;
        }

        // GET: EntitiesModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.EntitiesModel.ToListAsync());
        }

        // GET: EntitiesModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entitiesModel = await _context.EntitiesModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entitiesModel == null)
            {
                return NotFound();
            }

            return View(entitiesModel);
        }

        // GET: EntitiesModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EntitiesModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,Address,Area")] EntitiesModel entitiesModel)
        {
            if (ModelState.IsValid)
            {
                entitiesModel.Id = Guid.NewGuid();
                _context.Add(entitiesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entitiesModel);
        }

        // GET: EntitiesModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entitiesModel = await _context.EntitiesModel.FindAsync(id);
            if (entitiesModel == null)
            {
                return NotFound();
            }
            return View(entitiesModel);
        }

        // POST: EntitiesModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Number,Address,Area")] EntitiesModel entitiesModel)
        {
            if (id != entitiesModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entitiesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntitiesModelExists(entitiesModel.Id))
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
            return View(entitiesModel);
        }

        // GET: EntitiesModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entitiesModel = await _context.EntitiesModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entitiesModel == null)
            {
                return NotFound();
            }

            return View(entitiesModel);
        }

        // POST: EntitiesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var entitiesModel = await _context.EntitiesModel.FindAsync(id);
            _context.EntitiesModel.Remove(entitiesModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntitiesModelExists(Guid id)
        {
            return _context.EntitiesModel.Any(e => e.Id == id);
        }
    }
}
