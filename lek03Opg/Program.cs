using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek03Opg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Shape objects
            List<Shape> shapes = new List<Shape>();

            // Add some shapes to the list
            shapes.Add(new Circle(2, 3, 5));
            shapes.Add(new Rectangle(1, 1, 4, 6));
            shapes.Add(new Circle(0, 0, 3));
            shapes.Add(new Rectangle(5, 5, 2, 8));

            // Iterate over the list and print information about each shape
            foreach (Shape shape in shapes)
            {
                shape.PrintInfo();
            }

            Console.ReadLine();
        }
    }
}
