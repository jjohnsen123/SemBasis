using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek05opg51
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // OPG 5.1
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(0, 200));
            }

            var evenInts = list.Where(n => n % 2 == 0).ToList();

            evenInts.ForEach(n => Console.WriteLine(n));

            var lastInt = list.Last(n => n > 15);
            Console.WriteLine("Last int above 15: " + lastInt);

            var lastIntIndex = list.LastIndexOf(lastInt);
            Console.WriteLine("Index of last int above 15: " + lastIntIndex);

            //OPG 5.2
            IEnumerable<int> evenIntsLinQ = list.Where(n => n % 2 == 0);
            foreach (var item in evenIntsLinQ)
            {
                Console.WriteLine("Even Ints LinQ: " + item);
            }

            IEnumerable<int> intsTwoDigitsLinQ = list.Where(n => n.ToString().Length == 2);
            foreach (var item in intsTwoDigitsLinQ)
            {
                Console.WriteLine("Two Digit Ints LinQ: " + item);
            }

        }


    }
}
