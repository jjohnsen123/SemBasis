using Lesson05.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Web;

namespace Lesson05.Controllers
{
    public class Exercise03Controller : Controller
    {
        public ActionResult Index()
        {
            ParkingTicketMachine ptm = new ParkingTicketMachine();
            ViewBag.Payback = false; 
            return View(ptm);
        }

        private String GetFormdata(IFormCollection formdata, String key)
        {
            if (formdata[key].Count > 0 ) return formdata[key][0];
            return null;
        }

        [HttpPost]
        public ActionResult Index(IFormCollection formData) {

            // create a new instance of ParkingTicketMachine
            ParkingTicketMachine ptm = new ParkingTicketMachine();
            
            // declare a variable which keeps track of the amount inserted
            int AmountInserted;
            ViewBag.Payback = false;
            ViewBag.PaybackAmount = 0;
            
            // if the form field representing the amount is not null 
            if (GetFormdata(formData,"AmountInserted") != null) {
                AmountInserted = Convert.ToInt16(GetFormdata(formData, "AmountInserted")); // read the value of the amount inserted
            }
            else {
                AmountInserted = 0; // otherwise set the initial value to 0
            }
            
            if (GetFormdata(formData,"1") != null) {
                // call the insertCoin method with 1+AmountInserted as as parameter
                ptm.insertCoin(1 + AmountInserted);
            }
            else if (GetFormdata(formData,"2") != null) {
                ptm.insertCoin(2 + AmountInserted);
            }
            else if (GetFormdata(formData, "5") != null) {
                ptm.insertCoin(5 + AmountInserted);
            }
            else if (GetFormdata(formData, "10") != null) {
                ptm.insertCoin(10 + AmountInserted);
            }
            else if (GetFormdata(formData, "20") != null) {
                ptm.insertCoin(20 + AmountInserted);
            }

            if (GetFormdata(formData, "cancel") != null) {
                // reset the model to its initial state
                ViewBag.Payback = true;
                ViewBag.PaybackAmount = AmountInserted;
                ptm = new ParkingTicketMachine();
            }
            if (GetFormdata(formData, "confirm") != null) {
                ptm.insertCoin(AmountInserted);
                // load the receipt view named "confirm" with the model as parameter
                return View("confirm", ptm);
            }

            // load the default view with the model as parameter
            return View(ptm);
        }


    }
}
