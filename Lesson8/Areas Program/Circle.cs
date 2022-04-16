using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas_Program
{
    internal class Circle
    {
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Perimeter(double radius)
        {
            return Math.PI * radius * 2;
        }
    }
}
