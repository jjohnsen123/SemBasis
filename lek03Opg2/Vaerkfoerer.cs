using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg2
{
    internal class Vaerkfoerer : Mekaniker
    {
        public int ÅrForUdnævnelse { get; set; }
        public double TillægPrUge { get; set; }

        // Constructor
        public Vaerkfoerer(CprNr cpr, string navn, string adresse, string medarbejderNummer, int årForSvendeprøve, double timeløn, int årForUdnævnelse, double tillægPrUge)
            : base(cpr, navn, adresse, medarbejderNummer, årForSvendeprøve, timeløn)
        {
            ÅrForUdnævnelse = årForUdnævnelse;
            TillægPrUge = tillægPrUge;
        }

        // Override af BeregnUgeLøn til at inkludere tillægget i ugelønnen
        public override double BeregnUgeLøn()
        {
            return base.BeregnUgeLøn() + TillægPrUge;
        }
    }
}
