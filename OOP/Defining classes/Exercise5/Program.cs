using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dates = new DateModifier("2016 05 31", "2016 04 19");
            Console.WriteLine(dates.CalculateDifference());
        }
    }
}
