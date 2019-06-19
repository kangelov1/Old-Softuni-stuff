using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main()
        {
            //get input text from user
            string input = Console.ReadLine();

            //create a dictionary to store the occurance of each character
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if(!dict.ContainsKey(current))
                {
                    dict[current] = 0;
                }
                dict[current]++;
            }
            var supp = dict.OrderBy(x => x.Key);
            foreach(var kvp in supp)
            {
                Console.WriteLine("{0} {1}",kvp.Key,kvp.Value);
            }

            Console.Read();
        }
    }
}
