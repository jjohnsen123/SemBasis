using Microsoft.AspNetCore.Mvc;

namespace lek06opg1.Controllers
{
    public class SimpleCalculator : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculator(IFormCollection formCollection)
        {
            int number1 = Convert.ToInt32(formCollection["Number1"]);
            int number2 = Convert.ToInt32(formCollection["Number2"]);
            string operation = formCollection["operator"];

            double result = 0;
            bool error = false;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number1 != 0)
                    {
                        result = (double) number1 / number2;
                    } else
                    {
                        ViewBag.Error = "Divison by zero is not allowed.";
                        error = true;
                    }
                    break;
                default:
                    ViewBag.Error = "Invalid operator";
                    error = true;
                    break;

            }

            ViewBag.Number1 = number1.ToString();
            ViewBag.Number2 = number2.ToString();
            if (!error)
            {
                ViewBag.Result = result;
            }


            return View();
        }
    }
}
