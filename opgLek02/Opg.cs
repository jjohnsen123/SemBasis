using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgLek02
{
    internal class Opg
    {
        static void Main(string[] args)
        {
            while (!true)
            {
                Console.WriteLine("Indtast nummeret på det højeste Fibonacci-tal der skal udskrives (indtast 0 for at afslutte):");
                string input = Console.ReadLine();
                int n;

                try
                {
                    n = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ugyldigt input, prøv igen.");
                    continue;
                }

                if (n == 0)
                {
                    Console.WriteLine("Afslutter applikationen.");
                    break;
                }

                // Udskriv Fibonacci-talrækken ved brug af rekursion
                Console.WriteLine("Fibonacci-talrækken:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(Calc_fibonacci(i));
                }
            }

            Console.WriteLine("Indtast dit fødselsår:");
            int birthYear = int.Parse(Console.ReadLine());

            int age = Calc_Age(birthYear);
            Console.WriteLine("Din alder er: " + age);


            Console.WriteLine("Kalder MyNormalMethod...");
            MyNormalMethod();
            Console.WriteLine("Program afsluttet.");
        }

        static int Calc_fibonacci(int n)
        {
            if (n <= 1) { return n; }

            return Calc_fibonacci(n - 1) + Calc_fibonacci(n - 2);
        }

        static int Calc_Age(int birthYear)
        {
            int currYear = DateTime.Now.Year;
            int age = currYear - birthYear;
            return age;
        }

        static void MyMethodWithError(int num = 0)
        {
            Console.WriteLine("In MyMethodWithError");

            throw new InvalidOperationException("Error in MyMethodWithError");

        }

        static void MyNormalMethod(int num = 0)
        {
            try
            {
                Console.WriteLine("Inde i try-blokken i MyNormalMethod...");

                MyMethodWithError(num);
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Fejl fanget i MyNormalMethod: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Inde i finally-blokken i MyNormalMethod.");
            }
        }
    }
}
