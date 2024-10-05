using lek10bilerMVC.DAL;
using lek10bilerMVC.Model;
using Microsoft.AspNetCore.Mvc;

namespace lek10bilerMVC.Controllers
{
    public class BilController : Controller
    {
        private readonly BilContext _context;

        public BilController(BilContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();

        }

        public IActionResult Index()
        {
            var biler = _context.Biler.ToList();
            return View(biler);
        }

        public IActionResult CreateBil()
        {
            using (var context = new BilContext())
            {
                var newBil = new Bil { Name = "Toyota", Weight = 1300, Year = 2015 };
                context.Biler.Add(newBil);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
