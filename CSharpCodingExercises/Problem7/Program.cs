using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 156;
            int sum = 0;
            int m;
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write(sum);
            Console.ReadLine();
        }
    }
}