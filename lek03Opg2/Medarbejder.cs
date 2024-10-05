using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg2
{
    internal abstract class Medarbejder
    {
        // Private konstant for timer pr uge
        private const int _timerPrUge = 37;

        // Properties for navn, adresse, cpr-nummer og medarbejdernummer
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public CprNr CprNummer { get; set; }
        public string MedarbejderNummer { get; set; }

        // Constructor
        public Medarbejder(CprNr cpr, string navn, string adresse, string medarbejderNummer)
        {
            CprNummer = cpr;
            Navn = navn;
            Adresse = adresse;
            MedarbejderNummer = medarbejderNummer;
        }

        // Abstrakt metode til at beregne ugeløn
        public abstract double BeregnUgeLøn();

        // Property til at hente antallet af timer pr. uge (readonly)
        public int TimerPrUge
        {
            get { return _timerPrUge; }
        }

        // Override ToString for at udskrive medarbejderinformation
        public override string ToString()
        {
            return $"Medarbejder: {Navn}, Adresse: {Adresse}, CPR: {CprNummer}, MedarbejderNr: {MedarbejderNummer}";
        }
    }
}
