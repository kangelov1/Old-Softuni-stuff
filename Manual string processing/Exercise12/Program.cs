using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            //get two string from user
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            Console.WriteLine(CharacterMultiplier(input1,input2));

        }
        private static int CharacterMultiplier(string input1, string input2)
        {            
            //get two string
            //compare their length if they are equal use one for cycle from 0 to their length
            //if they have different length assign them to two string - "shorter" and "longer"
            //use a for cycle starting from 0 until the length of the shorter
            int sum = 0;
            if(input1.Length == input2.Length)
            {
                for(int i = 0; i < input1.Length; i++)
                {
                    sum += ((int)input1[i]) * ((int)input2[i]);
                }
            }
            else if(input1.Length > input2.Length)
            {
                string longer = input1;
                string shorter = input2;

                for(int i = 0; i < shorter.Length; i++)
                {
                    sum += ((int)longer[i]) * ((int)shorter[i]);
                }
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    sum += ((int)longer[i]);
                }
            }

            else if (input1.Length < input2.Length)
            {
                string longer = input2;
                string shorter = input1;

                for (int i = 0; i < shorter.Length; i++)
                {
                    sum += ((int)longer[i]) * ((int)shorter[i]);
                }
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    sum += ((int)longer[i]);
                }
            }

            return sum;
        }
    }
}
