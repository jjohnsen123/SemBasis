using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg
{
    internal abstract class Shape
    {
        public double X { get; set; } 
        public double Y { get; set; }

        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Shape() : this(1, 1)
        {
        }

        public abstract double Area();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Shape at ({X}, {Y})");
        }
    }

}

