using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = input[1];
            int baseN = input[0];

            Stack<int> digits = new Stack<int>();
            int currentDigit;
            int quotient = int.MaxValue;

            while(quotient > baseN)
            {
                currentDigit = number % baseN;
                digits.Push(currentDigit);
                quotient = number / baseN;
                number = quotient;
            }
            digits.Push(quotient);

            StringBuilder numInBaseN = new StringBuilder();
            while(digits.Count > 0)
            {
                numInBaseN.Append(digits.Pop());
            }
            Console.WriteLine(numInBaseN.ToString());
        }
    }
}
