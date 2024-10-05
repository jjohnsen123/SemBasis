using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver
{
    public delegate void Warning();
    internal class PowerPlant
    {
        private Warning warning;
        private Random random;

        public PowerPlant()
        {
            random = new Random();
        }

        //public void SetWarning(Warning warning)
        //{
        //    this.warning = warning;
        //}

        public void AddWarning(Warning wa)
        {
             warning += wa;
        }

        public void HeatUp()
        {
            int temperature = random.Next(0, 101);
            Console.WriteLine($"Temperature: {temperature}");

            if (temperature > 50)
            {
                warning?.Invoke();
            }
        }
    }
}
