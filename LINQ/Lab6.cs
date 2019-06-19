using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var sum = input.Split().Select(w =>
            {
                long value;
                bool success = long.TryParse(w, out value);
                return new { value, success };
            }).Where(a => a.success == true).Select(s => s.value).ToList().Sum();

            Console.WriteLine(sum);
        }
    }
}
