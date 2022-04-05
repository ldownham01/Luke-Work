using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottom = 9;
            // (bottom - i)/2 = number of spaces
            // i = number of stars
            for(int i = 1; i <= bottom; i = i + 2)
            {
                int spaces = ((bottom - i) / 2);

                Console.WriteLine(" ");
                  
                for (int k = 0; k < spaces; k++)
                {
                    Console.Write(" ");
                }
                
                for (int l = 0; l < i; l++)
                {
                Console.Write("*");}
                
            }
            Console.ReadLine();
        }
    }
}
