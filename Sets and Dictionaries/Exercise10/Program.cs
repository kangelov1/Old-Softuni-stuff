using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            dict["Brazil"] = new Dictionary<string, int>();
            dict["Brazil"]["Rio"] = 30;
            dict["Brazil"]["Rio2"] = 30;
            dict["Brazil"]["Rio3"] = 30;
            dict["Brazil"]["Rio4"] = 32;

            dict["Bulgaria"] = new Dictionary<string, int>();


            //get total population for country
           foreach(var country in dict.OrderByDescending(country => country.Value.Values.Sum()))
           {
               Console.WriteLine(string.Format("{0} total population: {1}",country.Key,country.Value.Values.Sum()));
               foreach(var city in country.Value.OrderByDescending(city => city.Value))
               {
                   Console.WriteLine(string.Format("{0} {1}",city.Key,city.Value));
               }
           }
        }
        static Dictionary<string,Dictionary<string,int>> CollectData()
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            while(true)
            {
                string input = Console.ReadLine();
                if(input == "report")
                {
                    break;
                }

                string[] values = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string city = values[0];
                string country = values[1];
                int population = int.Parse(values[2]);

                if(!dict.ContainsKey(country))
                {
                    dict[country] = new Dictionary<string, int>();
                }
                if(!dict[country].ContainsKey(city))
                {
                    dict[country][city] = 0;
                }
                dict[country][city] += population;
            }
            return dict;
        }
    }
}
