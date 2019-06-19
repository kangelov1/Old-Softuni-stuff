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
            List<string> input = new List<string>();

            string line = Console.ReadLine();
            while(line != "END")
            {
                input.Add(line);
                line = Console.ReadLine();
            }

            var result = input.Select(x =>
            {
                var values = x.Split();
                var name = values[0] + " " + values[1];
                var group = int.Parse(values[2]);
                return new { name, group };
            }
            ).Where(a => a.group == 2).GroupBy(a => a.group, a => a.name).ToList();

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
