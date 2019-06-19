using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main()
        {
            //create a dictionary to store resources and amount
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while(true)
            {
                string resource = Console.ReadLine();
                if(resource == "stop")
                {
                    break;
                }
                if(!dict.ContainsKey(resource))
                {
                    dict[resource] = 0;
                }
                int amount = int.Parse(Console.ReadLine());
                dict[resource] += amount;
            }

            foreach(var resource in dict)
            {
                Console.WriteLine("{0} {1}",resource.Key,resource.Value);
            }
        }
    }
}
