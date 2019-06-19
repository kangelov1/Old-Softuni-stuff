using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
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
                var firstName = values[0];
                var lastName = values[1];
                return new { firstName, lastName };
            }
            ).OrderBy(x => x.lastName).ThenByDescending(x => x.firstName).Select(x => string.Format("{0} {1}",x.firstName,x.lastName)).ToList();

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
