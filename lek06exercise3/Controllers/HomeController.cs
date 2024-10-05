using Microsoft.AspNetCore.Mvc;

namespace lek06exercise3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
