using lek06opg1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lek06opg1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person
            {
                Name = "Jeppe",
                Age = 26,
                Birthday = new DateTime(1998, 4, 5)
            };

            //string name = "Jeppe";
            //int age = 26;
            //DateTime birthday = new DateTime(1998, 4, 5);

            //ViewBag.Name = name;
            //ViewBag.Age = age;
            //ViewBag.Birthday = birthday.ToString("dd. MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture);

            return View(person);
        }
    }
}
