using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek05opg
{
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }

        public Person(string data)
        {
            var L = data.Split(';');

            Name = L[0];
            Age = int.Parse(L[1]);
            Weight = int.Parse(L[2]);
            Score = int.Parse(L[3]);
            Accepted = false;
        }

        public static List<Person> ReadCSVFile(string filename)
        {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var p = new Person(line);
                    list.Add(p);
                }
            }
            return list;
        }

        public override string? ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Score: {Score}, Is Accepted: {Accepted}";
        }

        public class SortByScoreAndAgeAscending : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int scoreComparison = x.Score.CompareTo(y.Score);
                if (scoreComparison == 0)
                {
                    return x.Age.CompareTo(y.Age);
                }
                return scoreComparison;
            }
        }

        public class SortByScoreAndAgeDescending : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int scoreComparison = y.Score.CompareTo(x.Score);
                if (scoreComparison == 0)
                {
                    return y.Age.CompareTo(x.Age);
                }
                return scoreComparison;
            }
        }


    }
}
