using CollegeApp.Entities.Data;
using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CollegeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CollegeContext _context;
        public HomeController(ILogger<HomeController> logger, CollegeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var enrollments = _context.Enrollments.FromSqlRaw("Exec spGetEnrollments").ToList();

            //var courses = _context.Courses.FromSqlRaw("Exec spGetAllActiveCourses").ToList();

            //foreach (var course in courses)
            //{
            //    Console.WriteLine(course.Name);
            //}
            var results = _context.StuTeacherModels.FromSqlInterpolated($"Exec spGetStuTeacher").ToList();

            foreach (var r in results)
            {
                Console.WriteLine(r.StudentName, r.TeacherName);
            }

            return View(enrollments);


        }

        public IActionResult Courses()
        {
            var results = _context.Courses.FromSqlRaw("Exec spCountCourses");
            return View(results);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}