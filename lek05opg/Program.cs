using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace lek05opg
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercise5_10();
        }

        public static void Exercise5_3()
        {
            List<Person> people1;

            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\johns\OneDrive - EFIF\4. semester\vsProjects\semBasis\lek05opg\data\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION" + ex.Message);
                Console.WriteLine("You should probably set the filename to the\r\nPerson.ReadCSVFile method to something on your disk!");
                return;
            }

            Console.WriteLine("All persons: ");
            people1.ForEach(p => Console.WriteLine(p));

            var scoreUnder2 = people1.FindAll(p => p.Score < 2);
            Console.WriteLine("\nPeople with a score under 2:");
            scoreUnder2.ForEach(p => Console.WriteLine(p));

            var evenScore = people1.FindAll(p => p.Score % 2 == 0);
            Console.WriteLine("\nPeople with an even score:");
            evenScore.ForEach(p => Console.WriteLine(p));

            var evenScoreAndWeightAbove60 = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
            Console.WriteLine("\nPeople with an even score and weight above 60:");
            evenScoreAndWeightAbove60.ForEach(p => Console.WriteLine(p));

            var weightDivisbleBy3 = people1.FindAll(p => p.Weight % 3 == 0);
            Console.WriteLine("\nPeople with a weigth divisble by 3:");
            weightDivisbleBy3.ForEach(p => Console.WriteLine(p));
        }


        public static void Exercise5_4()
        {
            List<Person> people1;

            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\johns\OneDrive - EFIF\4. semester\vsProjects\semBasis\lek05opg\data\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION" + ex.Message);
                Console.WriteLine("You should probably set the filename to the\r\nPerson.ReadCSVFile method to something on your disk!");
                return;
            }

            Console.WriteLine("All persons: ");
            people1.ForEach(p => Console.WriteLine(p));

            var firstIndexScore3 = people1.FindIndex(p => p.Score == 3);
            Console.WriteLine("\nIndex of first person with score of 3:");
            Console.WriteLine(firstIndexScore3);

            var firstIndexScore3andAgeUnder10 = people1.FindIndex(p => p.Age < 10 && p.Score == 3);
            Console.WriteLine("\nIndex of first person with score of 3 and age under 10:");
            Console.WriteLine(firstIndexScore3andAgeUnder10);

            var score3andAgeUnder10 = people1.FindAll(p => p.Age < 10 && p.Score == 3);
            Console.WriteLine("\nAmount of people with score of 3 and age under 10:");
            Console.WriteLine(score3andAgeUnder10.Count);

            var firstIndexScore3andAgeUnder8 = people1.FindIndex(p => p.Age < 8 && p.Score == 3);
            Console.WriteLine("\nIndex of first person with score of 3 and age under 8:");
            Console.WriteLine(firstIndexScore3andAgeUnder8);
        }

        public static void Exercise5_5()
        {
            List<Person> people1;

            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\johns\OneDrive - EFIF\4. semester\vsProjects\semBasis\lek05opg\data\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION" + ex.Message);
                Console.WriteLine("You should probably set the filename to the\r\nPerson.ReadCSVFile method to something on your disk!");
                return;
            }

            Console.WriteLine("All persons: ");
            people1.ForEach(p => Console.WriteLine(p));

            people1.Sort(new Person.SortByScoreAndAgeAscending());
            Console.WriteLine("\nAll persons sorted by score and age ascending: ");
            people1.ForEach(p => Console.WriteLine(p));

            people1.Sort(new Person.SortByScoreAndAgeDescending());
            Console.WriteLine("\nAll persons sorted by score and age descending: ");
            people1.ForEach(p => Console.WriteLine(p));
        }

        public static void Exercise5_6()
        {
            List<Person> people1;

            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\johns\OneDrive - EFIF\4. semester\vsProjects\semBasis\lek05opg\data\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION" + ex.Message);
                Console.WriteLine("You should probably set the filename to the\r\nPerson.ReadCSVFile method to something on your disk!");
                return;
            }

            people1.SetAcceptedP(p => p.Score >= 6 && p.Age <= 40);
            var peopleAccepted = people1.FindAll(p => p.Accepted == true);
            Console.WriteLine("\nAll persons accepted: ");
            peopleAccepted.ForEach(p => Console.WriteLine(p));
        }

        public static void Exercise5_7()
        {
            List<Person> people1;

            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\johns\OneDrive - EFIF\4. semester\vsProjects\semBasis\lek05opg\data\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION" + ex.Message);
                Console.WriteLine("You should probably set the filename to the\r\nPerson.ReadCSVFile method to something on your disk!");
                return;
            }

            var ascendingQuery = from p in people1
                                 orderby p.Score ascending, p.Age ascending
                                 select p;

            Console.WriteLine("\nAll persons sorted by score and age ascending with LinQ: ");
            foreach (var p in ascendingQuery)
            {
                Console.WriteLine(p);
            }


            var descendingQuery = from p in people1
                                 orderby p.Score descending, p.Age descending
                                 select p;

            Console.WriteLine("\nAll persons sorted by score and age descending with LinQ: ");
            foreach (var p in descendingQuery)
            {
                Console.WriteLine(p);
            }
        }

        public static void Exercise5_8()
        {
            int[] list = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

            var queryTwoDigitIntsAsc = from i in list
                                       where i > 9 && i < 100
                                       orderby i ascending
                                       select i;

            Console.WriteLine("\nAll two digit numbers sorted ascending: ");
            foreach (var i in queryTwoDigitIntsAsc)
            {
                Console.WriteLine(i);
            }


            var queryTwoDigitIntsDsc = from i in list
                                       where i > 9 && i < 100
                                       orderby i descending
                                       select i;

            Console.WriteLine("\nAll two digit numbers sorted descending: ");
            foreach (var i in queryTwoDigitIntsDsc)
            {
                Console.WriteLine(i);
            }

            var queryTwoDigitIntsAscToStr = from i in list
                                       where i > 9 && i < 100
                                       orderby i ascending
                                       select i.ToString();

            Console.WriteLine("\nAll two digit numbers as strings sorted ascending: ");
            foreach (var str in queryTwoDigitIntsAscToStr)
            {
                Console.WriteLine(str);
            }


            var queryTwoDigitIntsEvenOdd = from i in list
                                       where i > 9 && i < 100
                                       orderby i ascending
                                       select i % 2 == 0 ? $"{i} even" : $"{i} uneven";

            Console.WriteLine("\nAll two digit numbers with even/uneven sorted ascending: ");
            foreach (var i in queryTwoDigitIntsEvenOdd)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exercise5_9()
        {
            List<Person> people1;

            try
            {
                people1 = Person.ReadCSVFile(@"C:\Users\johns\OneDrive - EFIF\4. semester\vsProjects\semBasis\lek05opg\data\data1.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION" + ex.Message);
                Console.WriteLine("You should probably set the filename to the\r\nPerson.ReadCSVFile method to something on your disk!");
                return;
            }

            people1.SetAcceptedP(p => p.Score >= 6 && p.Age <= 40);
            var peopleAccepted = people1.FindAll(p => p.Accepted == true);
            Console.WriteLine("\nAll persons accepted: ");
            peopleAccepted.ForEach(p => Console.WriteLine(p));

            people1.Reset();
            Console.WriteLine("\nPersons accepted reset: ");
            people1.ForEach(p => Console.WriteLine(p));

        }

        public static void Exercise5_10()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                list.Add(rnd.Next(1, 500));
            }

            Console.WriteLine("Generated random numbers: ");
            Console.WriteLine(string.Join(", ", list));

            int oddCount = list.Count(i => i % 2 != 0);
            Console.WriteLine($"\nNumber of odd numbers: {oddCount}");

            int uniqueCount = list.Distinct().Count();
            Console.WriteLine($"\nNumber of unique numbers: {uniqueCount}");

            var firstThreeOddNumbers = list.Where(i => i % 2 != 0).Take(3);
            Console.WriteLine("First three odd numbers: " + string.Join(", ", firstThreeOddNumbers));

            var uniqueOddNumbers = list.Where(n => n % 2 != 0).Distinct();
            Console.WriteLine("Unique odd numbers: " + string.Join(", ", uniqueOddNumbers));

        }
    }
}
