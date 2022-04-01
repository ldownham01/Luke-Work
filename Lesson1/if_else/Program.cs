using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("first number is larger than second number");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("first number equals second number");
            }
            else
            {
                Console.WriteLine("Second number is greater than first number");
            }
            Console.ReadLine();
        }
    }
}
