using Microsoft.AspNetCore.Mvc;

namespace lek06opg1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TimeCalculator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TimeCalculator(IFormCollection formCollection)
        {
            int hours = Convert.ToInt32(formCollection["Hours"]);
            int minutes = Convert.ToInt32(formCollection["Minutes"]);
            int seconds = Convert.ToInt32(formCollection["Seconds"]);

            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds);
            double totalSeconds = ts.TotalSeconds;

            ViewBag.Hours = hours;
            ViewBag.Minutes = minutes;
            ViewBag.Seconds = seconds;
            ViewBag.TotalSeconds = totalSeconds;

            return View("TimeCalculatorResult");
        }
    }
}
