using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class and create a new object
            Calculator calc = new Calculator();
            // Create a local variable to hold the answer
            int x = 3;
            int y = 5;
            int sum = 0;
            sum = calc.Add(x, y);
            Console.WriteLine("sum of {1} + {2} = {3}", x, y, sum);
            Console.ReadLine();
        }
    }
}
