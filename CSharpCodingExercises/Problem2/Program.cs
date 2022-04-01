using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray";
            string[] anagrams = input.Split(',');

            for(int i = 0; i<anagrams.Length; i++)
            {
                if(anagrams[i].Length == 4 && charCount('s', anagrams[i]) == 1 && charCount('t', anagrams[i]) == 1 && charCount('a', anagrams[i]) == 1 && charCount('r', anagrams[i]) == 1)
                {
                    Console.WriteLine(anagrams[i]);
                }
            }
            Console.ReadLine();
        }

        static int charCount(char ch, string str)
        {
            int count = str.Split(ch).Length - 1;
            return count;
        }
    }
}
