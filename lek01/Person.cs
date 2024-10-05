using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek01
{
    internal class Person
    {
        public String name { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        override
            public String ToString()
        {
            return "Name is " + name;
        }
    }
}
