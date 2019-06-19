using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            //get input from user about number of queries N
            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            //create a stack to store numbers
            Stack<int> nums = new Stack<int>();

            for(int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                if(input[0] == 1)
                {
                    nums.Push(input[1]);
                }
                if(input[0] == 2)
                {
                    nums.Pop();
                }
                if(input[0] == 3)
                {
                    Console.WriteLine(nums.Max());
                }
            }
            Console.Read();
        }
    }
}
