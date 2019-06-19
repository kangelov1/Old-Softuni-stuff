using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            //get input from user about length of stack
            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            //create a stack to store numbers
            Stack<int> nums = new Stack<int>();

            //get numbers from user and store them
            for(int i = 0; i < N; i++)
            {
                nums.Push(int.Parse(Console.ReadLine()));
            }

            //pop all numbers from stack

            while(nums.Count > 0)
            {
                Console.WriteLine(nums.Pop());
            }

            Console.Read();
        }
    }
}
