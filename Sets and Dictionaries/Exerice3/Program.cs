using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerice3
{
    class Program
    {
        static void Main()
        {
            //get input about number of compunds n
            int n = int.Parse(Console.ReadLine());

            //create a sorted set to store them
            HashSet<string> set = new HashSet<string>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach(var compound in input)
                {
                    set.Add(compound);
                }
            }

            var supp = set.OrderBy(x => x);

            foreach(var compound in supp)
            {
                Console.WriteLine(compound);
            }

            Console.Read();
        }
    }
}
