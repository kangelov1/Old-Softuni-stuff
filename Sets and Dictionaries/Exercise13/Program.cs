using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            //singer @venue ticketsPrice ticketsCount
            //aggregate by venue - so primary key is venue
            //venue should be kept in order in which they were entered so Dictionary<string, ... >
            //value should be a dictionary with key singer and value int[] of tickets price and count
            //Dictionary<string,Dictionary<string,int[]>
                Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
                dict = GetData();
                foreach(var venue in dict)
                {
                    Console.WriteLine(venue.Key);
                    foreach(var entry in venue.Value.OrderByDescending(x=>x.Value))
                    {
                        Console.WriteLine("#{0} -> {1}",entry.Key,entry.Value);
                    }
                }
        }

        static Dictionary<string, Dictionary<string, int>> GetData()
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                int index = input.IndexOf("@");

                string singerName = input.Substring(0, index).TrimEnd();
                input = input.Remove(0, index + 1);

                //find last character in string
                int indexOfLastChar = int.MinValue;

                for(int i = input.Length - 1; i > 0; i--)
                {
                    if(char.IsLetter(input[i]))
                    {
                        indexOfLastChar = i;
                        break;
                    }
                }
                string venueName = input.Substring(0, indexOfLastChar + 1);
                var values = input.Remove(0, indexOfLastChar + 2).Split().ToArray();
                int total = int.Parse(values[0]) * int.Parse(values[1]);

                if(!dict.ContainsKey(venueName))
                {
                    dict[venueName] = new Dictionary<string, int>();
                }
                if(!dict[venueName].ContainsKey(singerName))
                {
                    dict[venueName][singerName] = total; 
                }
                else{
                    dict[venueName][singerName] += total;
                } 
            }

            return dict;
        }
    }
}
