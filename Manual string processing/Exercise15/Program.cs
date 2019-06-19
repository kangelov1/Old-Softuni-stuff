using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            //get string to shake
            string input = Console.ReadLine();
            //get pattern
            string pattern = Console.ReadLine();

            //get first and last index of pattern in string
            while (pattern.Length > 0)
            {

                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex != -1 && lastIndex != -1)
                {
                    input = input.Remove(lastIndex, pattern.Length).Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shake it");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
