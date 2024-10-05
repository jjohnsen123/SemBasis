using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Opg2og3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int i = 4.Factorial();

            Console.WriteLine($"4! er: {i}");

            i = 2.Power(4);

            Console.WriteLine($"4^2 er: {i}");
        }

        public static int Factorial(int n)
        {
            if (n == 0) return 1;

            return n * Factorial(n - 1);

        }

        public static int Power(int n, int p)
        {
            if (p == 0) return 1;

            return n * Power(n, p - 1);
        }
    }

    internal static class IntExtension
    {
        public static int Factorial(this int n)
        {
            if (n == 0) return 1;

            return n * Factorial(n - 1);
        }

        public static int Power(this int n, int p)
        {
            if (p == 0) return 1;

            return n * Power(n, p - 1);
        }
    }
}
