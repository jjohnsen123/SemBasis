using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerPlant plant = new PowerPlant();

            plant.AddWarning(ShowWarning);
            plant.AddWarning(ShowCriticalWarning);

            for (int i = 0; i < 10; i++)
            {
                plant.HeatUp();
            }
        }

        static void ShowWarning()
        {
            Console.WriteLine("Warning: Temperature too high!");
        }

        static void ShowCriticalWarning()
        {
            Console.WriteLine("Critical Warning: Temperature dangerously high!");
        }
    }
}
