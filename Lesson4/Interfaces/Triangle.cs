using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Triangle : IShape
    {
        public double bottom { get; set; }
        public double height { get; set; }

        public double Area()
        {
            return 0.5 * bottom * height;
        }

        public double Perimeter()
        {
            return bottom * 3;
        }
    }
}
