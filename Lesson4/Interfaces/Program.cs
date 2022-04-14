using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            double a = 10;
            double b = 20;
            double c = 1.0;

            double area = 0.0;
            double perimeter = 0.0;

            rectangle.height = a;
            rectangle.width = b;

            area = rectangle.Area();
            Console.WriteLine("Area of rectangle is : {0:F}", area);

            perimeter = rectangle.Perimeter();
            Console.WriteLine("Perimeter of rectangle is : {0:F}", perimeter);

            // Console.ReadLine();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Circle area and perimeter");

            circle.radius = c;

            area = circle.Area();
            Console.WriteLine("Area of circle is : {0:F}", area);

            perimeter = circle.Perimeter();
            Console.WriteLine("Perimeter of circle is : {0:F}", perimeter);

            Console.ReadLine();
        }
    }
}
