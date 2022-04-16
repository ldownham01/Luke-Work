using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            double a = 4;
            double b = 5;
            double c = 6;

            Console.WriteLine("Triangle area is " + triangle.Area(a, b, c));
            Console.WriteLine("Triangle perimeter is " + triangle.Perimeter(a, b, c));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Rectangle area is " + rectangle.Area(a, b));
            Console.WriteLine("Rectangle perimeter is " + rectangle.Perimeter(a, b));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Circle area is " + circle.Area(a));
            Console.WriteLine("Circle perimeter is " + circle.Perimeter(a));

            Console.ReadLine();
        }
    }
}
