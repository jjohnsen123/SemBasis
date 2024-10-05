using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opretter CPR-numre
            CprNr cpr1 = new CprNr("010190", "1234");
            CprNr cpr2 = new CprNr("150280", "5678");

            // Opretter en Mekaniker
            Mekaniker mekaniker = new Mekaniker(cpr1, "Peter Hansen", "Vesterbrogade 15", "M001", 2010, 200);
            Console.WriteLine(mekaniker.ToString());

            // Opretter en Værkfører
            Vaerkfoerer værkfører = new Vaerkfoerer(cpr2, "Jens Larsen", "Østerbrogade 30", "V001", 2005, 220, 2015, 500);
            Console.WriteLine(værkfører.ToString());

            // Opretter en Synsmand
            Synsmand synsmand = new Synsmand(cpr1, "Ole Sørensen", "Søndergade 2", "S001", 2012, 190, 15);
            Console.WriteLine(synsmand.ToString());
        }
    }
}
