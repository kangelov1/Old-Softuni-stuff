using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
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
                var age = int.Parse(values[2]);
                return new { name, age };
            }).Where(a => a.age > 18 && a.age < 24).Select(a => string.Format("{0} {1}", a.name, a.age)).ToList();

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
