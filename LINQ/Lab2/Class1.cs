using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Class1
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var result = input.Split().Select(c =>
            {
                var tokens = c.Split(':');
                var cityCode = tokens[0];
                var districtPopulation = long.Parse(tokens[1]);
                return new { cityCode, districtPopulation };
            }).GroupBy(a => a.cityCode,a => a.districtPopulation);
        }
    }
   
}
