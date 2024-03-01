using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Data;
using StudentPortal.Models;
using StudentPortal.Models.Entities;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppLicationDbContext dbContext;

        public StudentsController(AppLicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddStudentViewModel ViewModel)
        {
            var student = new Student
            {
                Name = ViewModel.Name,
                Email = ViewModel.Email,
                Phone = ViewModel.Phone,
                Subscribed = ViewModel.Subscribed,
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return View();            
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();

            return View(students);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var students = await dbContext.Students.FindAsync(id);

            return View(students);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student ViewModel)
        {
            var student = await dbContext.Students.FindAsync(ViewModel.Id);

            if (student is not null)
            {
                student.Name = ViewModel.Name;
                student.Email = ViewModel.Email;
                student.Phone = ViewModel.Phone;
                student.Subscribed = ViewModel.Subscribed;
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Student ViewModel)
        {
            var student = await dbContext.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id==ViewModel.Id);
            if (student is not null)
            {
                dbContext.Students.Remove(ViewModel);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");
        }
    }
}
