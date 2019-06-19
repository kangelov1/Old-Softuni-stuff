using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        public static int Additional(int N)
        { 
            if(N == 0 || N == 1)
            {
                return 1;
            }
            else
            {
                return (Additional(N -1) + Additional(N - 2)); 
            }
            
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Additional(a));
        }
    }
}
