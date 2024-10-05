using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek10ef.Model
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }

        public List<Bil> Biler {  get; set; }

        public Person()
        {
            Biler = new List<Bil>();    
        }
    }
}
