using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Type of dragon - primary key in dictionary
             * name - secondary key sorted 
             * each dragon has damage,health and armor
             * 
             */
            //Dictionary<string, Dictionary<string, Dictionary<string, int>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
            //dict["Red"] = new Dictionary<string, Dictionary<string, int>>();
            //dict["Red"]["Bazgargal"] = new Dictionary<string, int>();
            //dict["Red"]["Bazgargal"]["damage"] = 0;
            var dict = GetData();
            foreach(var dragon in dict.Values)
            {
                foreach (var name in dragon)
                {
                    Console.WriteLine("{0} {1}", name.Key, name.Value);
                    foreach(var stat in name.Value)
                    {
                        Console.WriteLine("{0} {1}",stat.Key,stat.Value);
                    }
                }
            }
           
        }

        static Dictionary<string,SortedDictionary<string,Dictionary<string,int>>> GetData()
        {
            Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> dict = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                //add type of dragon
                if(!dict.ContainsKey(input[0]))
                {
                    dict[input[0]] = new SortedDictionary<string, Dictionary<string, int>>();
                }

                //add name of dragon
                if(!dict[input[0]].ContainsKey(input[1]))
                {
                    dict[input[0]][input[1]] = new Dictionary<string, int>();
                }

                //add stats of dragon
                if(input[2] == "null")
                {
                    dict[input[0]][input[1]]["damage"] = 45;
                }
                else
                {
                    dict[input[0]][input[1]]["damage"] = int.Parse(input[2]);
                }

                if (input[3] == "null")
                {
                    dict[input[0]][input[1]]["health"] = 250;
                }
                else
                {
                    dict[input[0]][input[1]]["health"] = int.Parse(input[3]);
                }

                if (input[4] == "null")
                {
                    dict[input[0]][input[1]]["armor"] = 10;
                }
                else
                {
                    dict[input[0]][input[1]]["armor"] = int.Parse(input[4]);
                }
            }
            return dict;
        }

    }
}
