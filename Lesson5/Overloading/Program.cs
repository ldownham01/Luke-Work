using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            
            int a = 1;
            int b = 2;
            
            float c = 3.0f;
            float d = 4.0f;

            double e = 5.0d;
            double f = 6.0d;

            String firstName = "Joe";
            String LastName = "Bloggs";

            Console.WriteLine("Add int: {0}", calc.Add(a, b));
            Console.WriteLine("Add float: {0}", calc.Add(c, d));
            Console.WriteLine("Add double: {0}", calc.Add(e, f));
            Console.WriteLine("Add string : {0}", calc.Add(firstName, LastName));

            Console.ReadLine();
        }
    }
}
