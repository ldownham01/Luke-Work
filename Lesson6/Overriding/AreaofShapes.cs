using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class AreaofShapes : AreaofSquare
    {
        public double Rectangle(double a, double b)
        {
            // return area of rectangle
            return a * b;
        }
        //Overrides the square method in AreaofSquare
        public override double Square(double a, double b)
        {
            // return area of square using different implementation
            Console.WriteLine("Area of shapes called square a*b");
            return a * b;
        }
    }
}
