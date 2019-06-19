using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(n));
        }

        static int GetFibonacci(int n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }
            return (GetFibonacci(n - 1) + GetFibonacci(n -2));
        }
    }
}
