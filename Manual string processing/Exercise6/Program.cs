using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string subString = Console.ReadLine();

            int startIndex = 0;
            int occurances = 0;
            bool contains = true;

            while(contains)
            {
                if(input.IndexOf(subString,startIndex,StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    occurances++;
                    startIndex = input.IndexOf(subString, startIndex, StringComparison.CurrentCultureIgnoreCase) + 1;
                }
                else
                {
                    contains = false;
                }
            }
            Console.WriteLine(occurances);
        }
    }
}
