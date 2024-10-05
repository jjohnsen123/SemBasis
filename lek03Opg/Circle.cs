using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Circle at ({X}, {Y}), Radius: {Radius}, Area: {Area()}");
        }

    }
}

