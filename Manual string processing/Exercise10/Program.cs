using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main()
        {
            //get input from user
            string input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                var currentChar = (int)input[i];
                var inUnicode = currentChar.ToString("X4");
                Console.Write("\\u{0}",inUnicode);
            }
        }
    }
}
