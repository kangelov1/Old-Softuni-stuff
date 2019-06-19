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
            //get input from user about N - to add, S - to remove and X - to check
            Console.WriteLine("Enter N,S and X: ");
            var values = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            //create a queue to store numbers
            Queue<int> nums = new Queue<int>();

            //add N elements to queue
            for(int i = 0; i < values[0]; i++)
            {
                nums.Enqueue(int.Parse(Console.ReadLine()));
            }

            for(int i = 0; i < values[1]; i++)
            {
                nums.Dequeue();
            }

            if(nums.Contains(values[2]))
            {
                Console.WriteLine("True");
            }
            else if(nums.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                Console.WriteLine("{0}",nums.Min());
            }
        }
    }
}
