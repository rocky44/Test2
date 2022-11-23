using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test2.Models;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Display display = new Display();

            var students = new[]
            {
                new Students{ Id = 1, Name = "Student1", ClassId = 10, CountryId = 100},
                new Students{ Id = 2, Name = "Student2", ClassId = 10, CountryId = 100},
                new Students{ Id = 3, Name = "Student3", ClassId = 10, CountryId = 100},
                new Students{ Id = 4, Name = "Student4", ClassId = 11, CountryId = 101},
                new Students{ Id = 5, Name = "Student5", ClassId = 11, CountryId = 101},
                new Students{ Id = 6, Name = "Student6", ClassId = 12, CountryId = 102},
                new Students{ Id = 7, Name = "Student7", ClassId = 13, CountryId = 103},
                new Students{ Id = 8, Name = "Student8", ClassId = 13, CountryId = 103},
                new Students{ Id = 9, Name = "Student9", ClassId = 14, CountryId = 104},
            };

            var classes = new[]
            {
                new Classes{ ID = 10, Class_Name = "Science" },
                new Classes{ ID = 10, Class_Name = "Maths" },
                new Classes{ ID = 10, Class_Name = "English" },
                new Classes{ ID = 10, Class_Name = "Geography" },
            };

            var countries = new[]
            {
                new Countries{ Id = 101, Name = "India" },
                new Countries{ Id = 102, Name = "Australia" },
                new Countries{ Id = 103, Name = "England" },
                new Countries{ Id = 104, Name = "USA" },
            };

            display.StudentsInClass = from student in students
                                      join clas in classes
                                      on student.ClassId == clas
                                              select new StudentsInClass { ClassId = student.Id, StudentCount =  };

            display.StudentsInCountry = from student in students
                                        join country in countries
                                        on student.CountryId = cou
                                                  select new StudentsInCountry
                                                  {
                                                      CountryId = student.CountryId,
                                                      StudentCount = };

            display.AvgAge = students.Sum(x => x.DOB);

            return View(display);
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