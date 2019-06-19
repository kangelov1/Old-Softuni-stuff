using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            //create a set to store non - duplicate values Hashset for unsorted and SortedSet for sorted
            HashSet<string> usernames = new HashSet<string>();

            //get input from user about number of entries

            int n = int.Parse(Console.ReadLine());

            //get n usernames and store them in set

            for(int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            Console.WriteLine();

            foreach(var name in usernames)
            {
                Console.WriteLine(name);
            }

            Console.Read();
        }
    }
}
