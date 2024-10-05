using Microsoft.AspNetCore.Mvc;
using StartUp_CORE.Models;

namespace StartUp_CORE.Controllers
{
    public class Exercise02Controller : Controller
    {
        public IActionResult Index()
        {
            Person person1 = new Person("John", "Doe", "123 Elm Street", "12345", "Somewhere");
            person1.AddPhone("555-1234");
            person1.AddPhone("555-5678");
            person1.Birthday = new DateTime(1990, 5, 15);

            Person person2 = new Person("Jane", "Smith", "456 Oak Avenue", "67890", "Anywhere");
            person2.AddPhone("555-8765");
            person2.Birthday = new DateTime(1985, 8, 22);

            ViewBag.Person1 = person1;
            ViewBag.Person2 = person2;

            return View();
        }
    }
}
