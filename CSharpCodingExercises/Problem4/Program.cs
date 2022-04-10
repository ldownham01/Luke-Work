using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arr = {" ", " ", " ", " ", " ", " ", " ", " ", " "};

            int bottom = 9;
            int spaces = 5;
            //(bottom - i)/2 = number of spaces
            // i = number of stars
            for (int i = 1; i <= bottom; i = i + 2)
            {
                spaces = ((bottom - i) / 2);

                for (int j = 0; j < i; j++)
                {
                    arr[j + spaces] = "*";
                }

                for (int k = 0; k < arr.Length-1; k++)
                {
                    Console.Write(arr[k]);
                }
                Console.WriteLine(arr[arr.Length - 1]);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = " ";
            }


            for (int l = 7; l > 0; l = l - 2)
            {
                spaces = ((bottom - l) / 2);

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = " ";
                }

                for (int m = 0; m < l; m++)
                {
                    arr[spaces + m] = "*";
                }

                for (int k = 0; k < arr.Length-1; k++)
                {
                    Console.Write(arr[k]);
                }
                Console.WriteLine(arr[arr.Length - 1]);
            }


            Console.ReadLine();
        }
    }
}
