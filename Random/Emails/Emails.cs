using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userIpCount = CollectUserData();
        }

        private static SortedDictionary<string,Dictionary<string,int>> CollectUserData()
        {
            var userIpCount = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while(input != "end")
            {
                var userdata = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ipPredicate = userdata[0].IndexOf("IP=");
                var userPredicate = userdata[2].IndexOf("user=");

                if(userdata.Length != 3 || ipPredicate < 0 || userPredicate < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var IpAddress = userdata[0].Substring(ipPredicate + 3);
                var username = userdata[2].Substring(userPredicate + 5);
                if(!userIpCount.ContainsKey(username))
                {
                    userIpCount[username] = new Dictionary<string, int>();
                }
                if(!userIpCount[username].ContainsKey(IpAddress))
                {
                    userIpCount[username][IpAddress] = 0;
                }
                userIpCount[username][IpAddress]++;
            }
            return userIpCount;
        }
    }
}