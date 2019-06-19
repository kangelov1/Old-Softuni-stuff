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
            int N = int.Parse(Console.ReadLine());
            var family = new Family();
            for(int i = 0; i < N; i++)
            {
                var input = Console.ReadLine().Split();
                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }
            Console.WriteLine(family.OldestMember().Name + " " + family.OldestMember().Age);
        }
    }
}
