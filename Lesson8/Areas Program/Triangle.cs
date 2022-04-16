using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas_Program
{
    internal class Triangle
    {
        public double Area(double SideA, double SideB, double SideC)
        {
            double s = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(s * (s-SideA) * (s-SideB) * (s-SideC));
            return area;
        }

        public double Perimeter(double SideA, double SideB, double SideC)
        {
            return SideA + SideB + SideC;
        }
    }
}
