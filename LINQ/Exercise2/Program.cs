using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();

            string line = Console.ReadLine();
            while (line != "END")
            {
                input.Add(line);
                line = Console.ReadLine();
            }

            var result = input.Select(x => 
                { var values = x.Split();
                  var firstName = values[0];  
                    var lastName = values[1];
                    return new { firstName, lastName };
                }).Where(a => string.Compare(a.firstName,a.lastName) < 0 ).Select(a => string.Format("{0} {1}",a.firstName,a.lastName)).ToList();

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
