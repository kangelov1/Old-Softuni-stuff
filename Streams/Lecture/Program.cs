using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var num in nums.Distinct().Where(x => x >= 10 && x <= 20).Take(2))
            {
                Console.WriteLine(num);
            }
        }
    }
