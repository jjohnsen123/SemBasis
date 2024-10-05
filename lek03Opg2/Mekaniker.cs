using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg2
{
    internal class Mekaniker : Medarbejder
    {
        // Properties for årstal for svendeprøve og timeløn
        public int ÅrForSvendeprøve { get; set; }
        public double Timeløn { get; set; }

        // Constructor
        public Mekaniker(CprNr cpr, string navn, string adresse, string medarbejderNummer, int årForSvendeprøve, double timeløn)
            : base(cpr, navn, adresse, medarbejderNummer)
        {
            ÅrForSvendeprøve = årForSvendeprøve;
            Timeløn = timeløn;
        }

        // Override af BeregnUgeLøn til at beregne mekanikerens ugeløn
        public override double BeregnUgeLøn()
        {
            return Timeløn * TimerPrUge;
        }
    }
}
