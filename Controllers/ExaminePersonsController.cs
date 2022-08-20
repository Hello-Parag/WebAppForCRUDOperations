using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_DOTNET6.Models;
using CRUD_DOTNET6.Data;

namespace CRUD_DOTNET6.Controllers
{
    public class ExaminePersonsController : Controller
    {
        private readonly CRUD_DOTNET6Context _context;

        public ExaminePersonsController(CRUD_DOTNET6Context context)
        {
            _context = context;
        }

        // GET: ExaminePersons
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExaminePerson.ToListAsync());
        }

        // GET: ExaminePersons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examinePerson = await _context.ExaminePerson
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examinePerson == null)
            {
                return NotFound();
            }

            return View(examinePerson);
        }

        // GET: ExaminePersons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExaminePersons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Oraganization,ContactDetails,Feedback")] ExaminePerson examinePerson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(examinePerson);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(examinePerson);
        }

        // GET: ExaminePersons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examinePerson = await _context.ExaminePerson.FindAsync(id);
            if (examinePerson == null)
            {
                return NotFound();
            }
            return View(examinePerson);
        }

        // POST: ExaminePersons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Oraganization,ContactDetails,Feedback")] ExaminePerson examinePerson)
        {
            if (id != examinePerson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(examinePerson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExaminePersonExists(examinePerson.Id))
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
            return View(examinePerson);
        }

        // GET: ExaminePersons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examinePerson = await _context.ExaminePerson
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examinePerson == null)
            {
                return NotFound();
            }

            return View(examinePerson);
        }

        // POST: ExaminePersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var examinePerson = await _context.ExaminePerson.FindAsync(id);
            _context.ExaminePerson.Remove(examinePerson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExaminePersonExists(int id)
        {
            return _context.ExaminePerson.Any(e => e.Id == id);
        }
    }
}
