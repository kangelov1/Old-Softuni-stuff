using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(StringProcessing(input));
        }
        private static string StringProcessing(string input)
        {
            StringBuilder processed = new StringBuilder(20);
            if(input.Length >= 20)
            {
                for(int i = 0; i < 20; i++)
                {
                    processed.Append(input[i]);
                }
            }
            else
            {
                for(int i = 0; i < input.Length; i++)
                {
                    processed.Append(input[i]);
                }
                while(processed.Length <= 20)
                {
                    processed.Append('*');
                }
            }
            return processed.ToString();
        }
    }
}
