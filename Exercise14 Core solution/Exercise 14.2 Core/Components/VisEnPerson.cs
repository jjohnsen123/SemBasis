using Exercise_16_2_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_16_2_Core.Components
{
    [ViewComponent]
    public class VisEnPerson:ViewComponent
    {
        public IViewComponentResult Invoke(Person p)
        {
            if (p.Efternavn == "Ulsen")
            {
                p.Efternavn = "Olsen";
            }
            if (p.Efternavn == "Putin")
            {
                p.Efternavn = "Putler";
            }
            return View(p);
        }
    }
}
