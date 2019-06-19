using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            //get input from user about length of two sets n and m

            var sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //create two sets
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            //fill set1
            for(int i = 0; i < sizes[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            //fill set2
            for (int i = 0; i < sizes[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            set1.IntersectWith(set2);

            foreach(var num in set1)
            {
                Console.WriteLine(num);
            }
            Console.Read();
        }
    }
}
