using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>();
            Random r = new Random();

            for(int x = 0; x < 10; x++)
            {
                int
                num = r.Next(0, 100);
                Numbers.Add(num);
            }

            foreach(var number in Numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("-----------------");

            Console.WriteLine("Average of random numbers is: {0}", Numbers.Average());

            Numbers.Insert(10, 0);
            var index = Numbers.IndexOf(0);
            Console.WriteLine("index of position 0 is: {0}", index);

            var count = Numbers.Count();

            Console.WriteLine("count is : {0}", count);

            Console.WriteLine("-----------------");

            Console.WriteLine("Collections using List of objects");
            
            var Student = new List<Person>
            {
                new Person(){FirstName="Joe", LastName="Bloggs", age=23},
                new Person(){FirstName="Steve", LastName="May", age=22},
                new Person(){FirstName="Jack", LastName="Jones", age=24},
                new Person(){FirstName="Tom", LastName="Jones", age=23}
            };

            Console.WriteLine("number of objects is: {0}", Student.Count());

            foreach(var student in Student)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
                Console.WriteLine(student.age);
                Console.WriteLine("--------------------");
            }
            Console.ReadLine();
        }
    }
}
