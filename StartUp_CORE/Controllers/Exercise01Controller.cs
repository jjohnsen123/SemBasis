using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        

        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50);
            glass.ImageUrl = "grandcru.jpg";
            ViewBag.Glass = glass;

            Product bin35l = new Product("Bin 35l", 99.95);
            bin35l.ImageUrl = "bin_35l.jpg";
            ViewBag.Bin35l = bin35l;

            Product stKnife = new Product("Butterknife", 9.95, "st_knife.jpg", "Sterling Kitchenware");
            ViewBag.StKnife = stKnife;

            return View();
        }



    }
}
