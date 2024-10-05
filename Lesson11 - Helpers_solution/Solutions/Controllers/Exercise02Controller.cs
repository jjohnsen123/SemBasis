using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson05.Controllers
{
    public class Exercise02Controller : Controller
    {
    
        private Dictionary<string, decimal> breakfastPricelist = new Dictionary<string, decimal>();
        
        public ActionResult Index()
        {
       
            List<SelectListItem> breakfastItems = new List<SelectListItem>();
            
            breakfastItems.Add(new SelectListItem { Text = "Cornflakes", Value = "Cornflakes"});
            breakfastItems.Add(new SelectListItem { Text = "Egg", Value = "Egg" });
            breakfastItems.Add(new SelectListItem { Text = "Toast", Value = "Toast" });
            breakfastItems.Add(new SelectListItem { Text = "Juice", Value = "Juice" });
            breakfastItems.Add(new SelectListItem { Text = "Milk", Value = "Milk" });
            breakfastItems.Add(new SelectListItem { Text = "Tea", Value = "Tea" });
            breakfastItems.Add(new SelectListItem { Text = "Coffee", Value = "Coffee" });
            ViewBag.BreakfastItems = breakfastItems;

            return View(breakfastItems);
        }


        [HttpPost]
        public ActionResult Index(IFormCollection formData) {
            breakfastPricelist.Add("Cornflakes", 25.50m);
            breakfastPricelist.Add("Egg", 15.75m);
            breakfastPricelist.Add("Toast", 12.50m);
            breakfastPricelist.Add("Juice", 18.00m);
            breakfastPricelist.Add("Milk", 15.25m);
            breakfastPricelist.Add("Tea", 12.50m);
            breakfastPricelist.Add("Coffee", 16.00m);
    
            
            ViewBag.Name = formData["fullname"];
            ViewBag.RoomNumber = formData["roomnumber"];
            DateTime dt = DateTime.Parse(formData["time"]);
            ViewBag.Time = dt.ToLongDateString();
            ViewBag.BreakfastPricelist = breakfastPricelist;
            
            // breakfastlist as a commaseparated string with "false" values
            string breakfastItems = formData["breakfastItems"];
            // create a string array of the sring
            string[] items = breakfastItems.Split(',');
            
            List<string> selectedItems = new List<string>();;

            // loop through the list 
            // and add elements which are not "false" to the selectedItems list
            decimal total = 0;
            foreach (string item in items) {
                if (item != "false") {
                    selectedItems.Add(item + " (" + breakfastPricelist[item] + ") ");
                    total += breakfastPricelist[item];
                }
            }

            ViewBag.TotalPrice = total;


            // convert the list to a string array
            string[] resultList = selectedItems.ToArray();
            // create a commaseparated string from the string array
            breakfastItems = string.Join(", ", resultList);

            ViewBag.BreakfastItems = breakfastItems.ToString();
            return View("receipt");
        }

    }
}
