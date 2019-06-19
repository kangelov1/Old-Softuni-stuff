using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main()
        {
            //create two dictionaries to store key materials and junk

            Dictionary<string, int> dictKey = new Dictionary<string, int>();
            Dictionary<string, int> dictJunk = new Dictionary<string, int>();


            //get input from user in format {quantity} {material} {quantity} {material}
            while(true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for(int i = 0; i <= input.Length - 2; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var material = input[i + 1].ToLower();
                    if(material == "shards" || material == "fragments" || material == "motes")
                    {
                        if(!dictKey.ContainsKey(material))
                        {
                            dictKey[material] = 0;
                        }
                        dictKey[material] += quantity;
                    }
                    else
                    {
                        if (!dictJunk.ContainsKey(material))
                        {
                            dictJunk[material] = 0;
                        }
                        dictJunk[material] += quantity;
                    }
                }

                bool test = dictKey.Values.Any(x => x >= 250);
                if(test)
                {
                    break;
                }
            }

            //get the key of the item with 250 or more quantity
            var supp = dictKey.Where(x => x.Value >= 250);
            string collectedKey = " ";
            foreach(var kvp in supp)
            {
                collectedKey = kvp.Key;
            }
            dictKey[collectedKey] -= 250;
            
            //print the item
            switch(collectedKey)
            {
                case "motes":
                    Console.WriteLine("Dragonwrath");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr");
                    break;
                case "shards":
                    Console.WriteLine("Shadowmourne");
                    break;
            }
            Console.WriteLine();
            foreach(var kvp in dictKey.OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine(string.Format("{0} {1}",kvp.Key,kvp.Value));
            }
            Console.WriteLine();
            foreach(var kvp in dictJunk.OrderBy(kvp => kvp))
            {
                Console.WriteLine(string.Format("{0} {1}",kvp.Key,kvp.Value));
            }
        }
    }
}
