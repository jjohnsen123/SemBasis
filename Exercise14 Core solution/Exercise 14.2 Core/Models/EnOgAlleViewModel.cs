using Exercise_16_2_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_16_2_Core.Models
{
    public class EnOgAlleViewModel
    {
        public Person ValgtPerson { get; set; }
        public List<Person> AllePersoner { get; set; }

        public EnOgAlleViewModel(Person valgtPerson, List<Person> allePersoner)
        {
            ValgtPerson = valgtPerson;
            AllePersoner = allePersoner;
        }
    }
}