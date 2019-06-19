using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_ver2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> dict = new SortedDictionary<string, SortedDictionary<string, int>>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                var userName = input[1];
                var ipAddress = input[0];
                var duration = int.Parse(input[2]);

                if(!dict.ContainsKey(userName))
                {
                    dict[userName] = new SortedDictionary<string, int>();
                }
                if(!dict[userName].ContainsKey(ipAddress))
                {
                    dict[userName][ipAddress] = 0;
                }
                dict[userName][ipAddress] += duration;
            }

            foreach(var user in dict)
            {
                var addresses = string.Join(";", user.Value.Keys);
                Console.WriteLine("{0} {1} {2}",user.Key,user.Value.Values.Sum(),addresses);
            }

            Console.Read();
        }
    }
}
