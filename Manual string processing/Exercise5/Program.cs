using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input from user 
            var input = Console.ReadLine().Split().ToArray();

            //first entry is the base
            double baseN = double.Parse(input[0]);

            //second entry is the number
            string numInBaseN = input[1];

            //initialize power to 0
            double power = 0;
            //initialize num in base 10 to 0
            double numInBase10 = 0;


            for(int i = numInBaseN.Length - 1; i >= 0; i--)
            {
                var current = char.GetNumericValue(numInBaseN[i]);
                double mult = Math.Pow(baseN, power);
                numInBase10 += current * mult;
                power++;
            }

            Console.WriteLine(numInBase10);
        }
    }
}
