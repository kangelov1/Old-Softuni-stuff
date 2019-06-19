using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main()
        {
            //get strings from user
            var strings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //get the position of the first letter in the alphabet
            //two cases Uppercase - subtract 64 Lowercase - subtract 96

            Console.WriteLine(ChangeLetter(strings));
        }
        private static double ChangeLetter(string[] strings)
        {
            double total = 0;

            for(int i = 0; i < strings.Length; i++)
            {
                string current = strings[i];//get the first string in the array will use a for cycle
                int value;
                bool isUpper = true;
                if (char.IsUpper(current[0]))//check if the letter is upper
                {
                    value = (int)current[0] - 64;
                }
                else
                {
                    value = (int)current[0] - 96;
                    isUpper = false;
                }

                //exctract number from string
                double number = double.Parse(current.Substring(1, current.Length - 2));

                if (isUpper)
                {
                    total += number / value;
                }
                else
                {
                    total += number * value;
                }

                if (char.IsUpper(current[current.Length - 1]))//check if the letter is upper
                {
                    value = (int)current[current.Length - 1] - 64;
                    isUpper = true;
                }
                else
                {
                    value = (int)current[current.Length - 1] - 96;
                    isUpper = false;
                }

                if (isUpper)
                {
                    total -= value;
                }
                else
                {
                    total += value;
                }
            }
            return total;
        }
    }
}
