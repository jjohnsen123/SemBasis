using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;


namespace lek07opg1.Controllers
{
    public class Exercise01Controller : Controller
    {
        private List<SelectListItem> countries;

        public IActionResult Index(string country)
        {
            ViewBag.CountryCode = country;
            // Initialize the country list if session is empty  
            // if the session variable isn't set you create the list and store it in a session
            if (HttpContext.Session.GetString("countryList") == null)
            {
                countries = new List<SelectListItem>()
                {
                    new SelectListItem { Text = "China", Value = "CN" },
                    new SelectListItem { Text = "Denmark", Value = "DK" },
                    new SelectListItem { Text = "France", Value = "FR" },
                    new SelectListItem { Text = "USA", Value = "US" }
                };

                HttpContext.Session.SetString("countryList", JsonConvert.SerializeObject(countries));
            }
            else
            {
                // Retrieve the countries list from session
                var countryListJson = HttpContext.Session.GetString("countryList");
                countries = JsonConvert.DeserializeObject<List<SelectListItem>>(countryListJson);
            }

            Infrastructure.Utilities.SortSelectList(countries);

            ViewBag.Countries = countries;

            return View();

        }

        [HttpPost]
        public IActionResult Index(IFormCollection formData)
        {
            var countryListJson = HttpContext.Session.GetString("countryList");
            countries = JsonConvert.DeserializeObject<List<SelectListItem>>(countryListJson);

            string countryName = formData["countryName"];
            string countryCode = formData["countryCode"];

            countries.Add(new SelectListItem { Text = countryName, Value = countryCode });

            HttpContext.Session.SetString("countryList", JsonConvert.SerializeObject(countries));

            ViewBag.Countries = countries;

            return RedirectToAction("Index");
        }
    }
}
