using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_ver2
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if(input.Length >= 20)
            {
                Console.WriteLine(input.Substring(0,20));
            }
            else if(input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20,'*'));
            }

        }
    }
}
