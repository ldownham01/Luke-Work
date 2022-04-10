using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = isPalindrome("book"); ;
            Console.WriteLine(input);
            Console.ReadLine();
        }

        public static string reverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string output = new string(arr);
            return output;
        }

        public static string isPalindrome(string s)
        {
            if(s == reverseString(s))
            {
                return "Palindrome";
            }
            else
            {
                return "Not Palindrome";
            }
        }
    }
}
