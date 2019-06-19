using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Person();
            Console.WriteLine(test.ToString());
            var test2 = new Person(18);
            Console.WriteLine(test2.ToString());
            var test3 = new Person("Gosho", 18);
            Console.WriteLine(test3.ToString());
        }
    }
}
