using lek10bilerMVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lek10bilerMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly BilContext _context;

        public PersonController(BilContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var personer = _context.Personer.Include(p => p.Biler).ToList();
            return View(personer);
        }
    }
}
