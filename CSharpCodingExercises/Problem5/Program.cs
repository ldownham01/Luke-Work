using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string output = new string(arr);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
