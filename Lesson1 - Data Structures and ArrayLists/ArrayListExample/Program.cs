using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double average;
            int grade = 0;
            int total = 0;

            //Instantiate an Array List
            ArrayList grades = new ArrayList();
            //Instantiate a random class
            Random r = new Random();

            for(int x = 0; x < 10; x++)
            {
                //generate a grade and add to arraylist
                grade = (int) r.Next(0,100);
                grades.Add(grade);
            }

            for(int i = 0; i < grades.Count; ++i)
            {
                //print out grades
                Console.WriteLine("grades[" + i + "] = " + (int) grades[i]);
                total += (int) grades[i];
            }

            average = total / grades.Count;
            Console.WriteLine("The averages is " + average);
            Console.ReadLine();
        }
    }
}
