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
            int N = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for(int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split();

                people.Add(new Person(input[0], int.Parse(input[1])));
               
            }

            foreach (var person in people.Where(a => a.Age > 30).OrderBy(a => a.Name).ToList())
            {
                Console.WriteLine("{0} {1}", person.Name, person.Age);
            }
        }
    }
}
