using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg2
{
    internal class Synsmand : Mekaniker
    {
        // Property for antal syn
        public int AntalSyn { get; set; }

        // Constructor
        public Synsmand(CprNr cpr, string navn, string adresse, string medarbejderNummer, int årForSvendeprøve, double timeløn, int antalSyn)
            : base(cpr, navn, adresse, medarbejderNummer, årForSvendeprøve, timeløn)
        {
            AntalSyn = antalSyn;
        }

        // Metode til at beregne ugeløn
        public double BeregnUgeløn()
        {
            return AntalSyn * 290;
        }
    }
}
