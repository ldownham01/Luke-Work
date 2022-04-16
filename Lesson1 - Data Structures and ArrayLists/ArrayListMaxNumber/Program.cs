using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double average;
            int highest = 0;
            int number = 0;

            //Instantiate an Array List
            ArrayList grades = new ArrayList();
            //Instantiate a random class
            Random r = new Random();

            for (int x = 0; x < 10; x++)
            {
                //generate a grade and add to arraylist
                number = (int)r.Next(0, 100);
                grades.Add(number);
            }

            for (int i = 0; i < grades.Count; ++i)
            {
                //print highest grades
                Console.WriteLine("grades[" + i + "] = " + (int)grades[i]);
                if((int) grades[i] > highest)
                {
                    highest = (int) grades[i];
                }
            }

            Console.WriteLine("The highest grade is " + highest);
            Console.ReadLine();
        }
    }
}
