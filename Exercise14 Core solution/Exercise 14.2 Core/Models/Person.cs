using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_16_2_Core.Models
{
    public class Person
    {
        public Person() { }
        public Person(string fornavn, string efternavn)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
        }

        public String Fornavn { get; set; }
        public String Efternavn { get; set; }
    }
}