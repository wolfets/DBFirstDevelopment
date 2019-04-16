using DBFirstDevelopment.Models.DB;
using DBFirstDevelopment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstDevelopment.Controllers
{
    public class StudentsController : Controller
    {
        //private readonly EFCoreDBFirstDemoContext _context;
        private readonly IStudentItemService _context;

        public StudentsController(IStudentItemService context)
        {
            _context = context;    
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Student.ToListAsync());
            return View(await _context.getAllAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.getByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,FirstName,LastName,Gender,DateOfBirth,DateOfRegistration,PhoneNumber,Email,Address1,Address2,City,State,Zip")] Student student)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(student);
                //await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.getByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("StudentId,FirstName,LastName,Gender,DateOfBirth,DateOfRegistration,PhoneNumber,Email,Address1,Address2,City,State,Zip")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(student);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!StudentExists(student.Id))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.getByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var student = await _context.delByIdAsync(id);
            //student. Remove(student);
            //await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //private async bool StudentExists(Guid id)
        //{
        //    return await _context.getAllAsync().Any(e => e.Id == id);
        //}
    }
}
