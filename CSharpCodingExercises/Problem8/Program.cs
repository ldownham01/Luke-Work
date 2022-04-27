using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
        {
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    int temp = list[i] + list[j];
                    if(temp == sum && i != j)
                    {
                        var tuple = Tuple.Create(list[i], list[j]);
                        return tuple;
                    }
                }
            }

            return null;
        }
    }
}
