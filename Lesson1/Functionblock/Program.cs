using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionblock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Function to add two numbers
            int a = 5;
            int b = 4;
            int sum = 0;

            sum = Add(a, b);
            Console.WriteLine("sum = {0}", sum);
            Console.ReadLine();
        }

        // function to add two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // function to return the square of a number
        public static int Square(int a)
        {
            return a * a;
        }
    }
}
