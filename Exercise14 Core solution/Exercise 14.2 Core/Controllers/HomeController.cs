using Exercise_16_2_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_16_2_Core.Controllers
{
    public class HomeController : Controller
    {
        private List<Person> AllePersoner()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Ole", "Ulsen"));
            persons.Add(new Person("Ib", "Ibsen"));
            persons.Add(new Person("Vladimir", "Putin"));
            return persons;
        }
        public ActionResult VisAlle()
        {
            return View(AllePersoner());
        }
        public ActionResult VisEn()
        {
            return View(new EnOgAlleViewModel(AllePersoner()[0], AllePersoner()));
        }
    }
}