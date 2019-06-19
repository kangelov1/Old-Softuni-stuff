using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_ver2
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder reversed = new StringBuilder(input.Length);
            for(int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            Console.WriteLine(reversed.ToString());
        }
    }
}
