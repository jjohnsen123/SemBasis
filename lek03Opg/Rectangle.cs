using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg
{
    internal class Rectangle : Shape 
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double x, double y, double length, double width) : base(x, y)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Rectangle at ({X}, {Y}), Length: {Length}, Width: {Width}, Area: {Area()}");
        }
    }
}
