using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek10bilerMVC.Model
{
    public class Bil
    {
        public int BilID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Year { get; set; }

        public int PersonID { get; set; }
        public Person Owner { get; set; }


        public Bil() { }

        public Bil(string name, int weight, int year)
        {
            Name = name;
            Weight = weight;
            Year = year;
        }
    }
}
