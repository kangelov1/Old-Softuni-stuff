using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Reverse(input));
        }
        private static string Reverse(string initial)
        {
            StringBuilder reversed = new StringBuilder(initial.Length);

            for(int i = initial.Length - 1; i >= 0; i--)
            {
                reversed.Append(initial[i]);
            }
            return reversed.ToString();
        }
    }
}
