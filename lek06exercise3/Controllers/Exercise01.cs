using lek06exercise3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lek06exercise3.Controllers
{
    public class Exercise01 : Controller
    {
        public IActionResult Index()
        {
            Book book1 = new Book
            {
                Title = "ASP.NET MVC Guide",
                Price = 29.99m,
                ImageUrl = "mvc_guide.jpg",
                Author = "John Doe",
                Publisher = "Tech Books Publishing",
                Published = 2023,
                ISBN = "978-1-2345-6789-0"
            };

            MusicCD cd1 = new MusicCD
            {
                Title = "Greatest Hits - CD",
                Price = 99.95m,
                ImageUrl = "greatest_hits.jpg",
                Artist = "Guns N' Roses",
                Label = "Geffen",
                Released = 2004
            };
            cd1.AddTrack("1 Welcome To The Jungle");
            cd1.AddTrack("2 Sweet Child O' Mine");
            cd1.AddTrack("3 Patience");
            cd1.AddTrack("4 Paradise City");
            cd1.AddTrack("5 Knockin' On Heaven's Door");
            cd1.AddTrack("6 Civil War");
            cd1.AddTrack("7 You Could Be Mine");
            cd1.AddTrack("8 Don't Cry (Original)");
            cd1.AddTrack("9 November Rain");
            cd1.AddTrack("10 Live And Let Die");
            cd1.AddTrack("11 Yesterdays");
            cd1.AddTrack("12 Ain't It Fun");
            cd1.AddTrack("13 Since I Don't Have You");
            cd1.AddTrack("14 Sympathy For The Devil");

            ViewBag.Book1 = book1;
            ViewBag.CD1 = cd1;

            return View();
        }
    }
}
