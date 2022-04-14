﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Circle : IShape
    {
        public double radius { get; set; }

        public double Area()
        {
            return Math.PI * radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
