using Microsoft.AspNetCore.Mvc;

namespace lek06opg1.Controllers
{
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {
            string[] rockbands = new string[10]
            {
                "Led Zeppelin",
                "Pink Floyd",
                "The Rolling Stones",
                "Nirvana",
                "The Beatles",
                "AC/DC",
                "Queen",
                "Metallica",
                "Guns N' Roses",
                "The Who"
            };

            ViewBag.Rockbands = rockbands;

            return View();
        }
    }
}
