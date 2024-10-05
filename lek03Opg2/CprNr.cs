using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg2
{
    internal class CprNr
    {
        // Auto-implemented properties
        public string BirthDate { get; set; }
        public string SequenceNumber { get; set; }

        // Constructor
        public CprNr(string bDate, string sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }

        // Override ToString for at formatere CPR nummer
        public override string ToString()
        {
            return $"{BirthDate}-{SequenceNumber}";
        }


    }
}
