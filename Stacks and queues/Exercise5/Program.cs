using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main()
        {
            //create a queue to store numbers 

            Queue<int> nums = new Queue<int>();

            //first member is input from the user

            nums.Enqueue(int.Parse(Console.ReadLine()));
            int current = nums.Dequeue();
            Console.Write(current + " ");
            for(int i = 0; i < 30; i++)
            {
                nums.Enqueue(current + 1);
                nums.Enqueue(current * 2 + 1);
                nums.Enqueue(current + 2);
                current = nums.Dequeue();
                Console.Write(current + " ");
            }
            Console.WriteLine("");
        }
    }
}
