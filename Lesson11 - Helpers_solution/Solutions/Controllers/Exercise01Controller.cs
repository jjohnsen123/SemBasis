using Lesson04.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Lesson04.Controllers
{
    public class Exercise01Controller : Controller
    {
        //
        // GET: /Exercise02/

        private List<SelectListItem> countryList = new List<SelectListItem>();

        public ActionResult Index(string Countries)
        {
            // if the session variable isn't set you create the list and store it in a session
            if (HttpContext.Session.GetString("countryList") == null)
            {
                countryList.Add(new SelectListItem { Text = "China", Value = "CN" });
                countryList.Add(new SelectListItem { Text = "Denmark", Value = "DK", Selected = true });
                countryList.Add(new SelectListItem { Text = "France", Value = "FR" });
                countryList.Add(new SelectListItem { Text = "USA", Value = "US" });
                HttpContext.Session.SetString("countryList", JsonConvert.SerializeObject(countryList));
            }
            else
            {
                // if the sessionvariale is set you'll make a reference to it
                // note that session variable is not strongly typed
                // that's because all types of variables can be stored in sessions
                // therefore you must typecast it to the right type when you assign it to a variable
                countryList = JsonConvert.DeserializeObject<List<SelectListItem>>(HttpContext.Session.GetString("countryList"));
            }

            ViewBag.Countries = countryList;
            ViewBag.CountryCode = Countries;

            return View();
        }

        [HttpPost]
        public ActionResult Index(IFormCollection formData)
        {

            countryList = JsonConvert.DeserializeObject<List<SelectListItem>>(HttpContext.Session.GetString("countryList"));

            countryList.Add(new SelectListItem { Text = formData["country"], Value = formData["code"], Selected = true });
            Utilities.SortSelectList(countryList, formData["code"]);

            ViewBag.Country = formData["country"];
            ViewBag.Code = formData["code"];

            ViewBag.Countries = countryList;
            HttpContext.Session.SetString("countryList", JsonConvert.SerializeObject(countryList));


            return View();
        }

    }
}
