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
            //get input from user about N - number of elements to add S - number of elements to pop and X - element to check for
            string input = Console.ReadLine();
            var values = input.Split().Select(x => int.Parse(x)).ToArray();

            //create a stack to store values
            Stack<int> nums = new Stack<int>();

            //get N numbers from user
            for(int i = 0; i < values[0]; i++)
            {
                nums.Push(int.Parse(Console.ReadLine()));
            }

            //pop S number of elements from stack
            for(int i = 0; i < values[1]; i++)
            {
                nums.Pop();
            }

            if(nums.Contains(values[2]))
            {
                Console.WriteLine("True");
            }
            else if(nums.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("{0}",nums.Min());
            }
        }
    }
}
