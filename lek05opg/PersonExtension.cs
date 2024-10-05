using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek05opg
{
    public static class PersonExtension
    {
        public static void SetAcceptedP(this List<Person> list, Predicate<Person> pred)
        {
            var accepted = list.FindAll(pred);
            accepted.ForEach(p => p.Accepted = true);
        }

        public static void Reset(this List<Person> list)
        {
            var accepted = list.FindAll(P => P.Accepted);
            accepted.ForEach(p => p.Accepted = false);
        }
    }
}
