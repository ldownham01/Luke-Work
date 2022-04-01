using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0";
            string[] numbers = input.Split(',');
            int temp = 0;
            int count = 0;

            for (int i = 0; i<numbers.Length; i++)
            {
                if(numbers[i] == "0")
                {
                    temp++;
                }
                else
                {
                    temp = 0;
                }

                if (temp > count)
                {
                    count = temp;
                }
            }
            Console.WriteLine("The longest number of days without sales is: {0}", count);
            Console.ReadLine();
        }
    }
}
