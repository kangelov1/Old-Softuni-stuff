using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, UserStat> userData = GetInput();
            foreach(var user in userData)
            {
                string adresses = string.Join(",",user.Value.IpHistory);
                Console.WriteLine("{0} {1} {2}",user.Key,user.Value.Duration,adresses);
            }

            Console.Read();
        }
        static SortedDictionary<string,UserStat> GetInput()
        {
            var userData = new SortedDictionary<string, UserStat>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var ipAddress = input[0];
                var username = input[1];
                var duration = int.Parse(input[2]);

                if(!userData.ContainsKey(username))
                {
                    userData[username] = new UserStat
                    {
                        IpHistory = new SortedSet<string>(),
                        Duration = 0
                    };
                }

                userData[username].IpHistory.Add(ipAddress);
                userData[username].Duration += duration;
            }

            return userData;
        }
    }
}
