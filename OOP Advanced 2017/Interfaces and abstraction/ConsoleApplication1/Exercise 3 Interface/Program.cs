using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = Console.ReadLine();
            ICar car = new Ferrari(driver);
            Console.WriteLine(car);
        }
    }
}
