using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a stack to hold numbers

            Stack<int> nums = new Stack<int>();
            nums.Push(1);
            nums.Push(1);

            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    var temp = nums.Pop();
                    var current = temp + nums.Peek();
                    nums.Push(temp);
                    nums.Push(current);
                }
            }
            Console.WriteLine(nums.Peek()); 
            Console.Read();
        }
    }
}
