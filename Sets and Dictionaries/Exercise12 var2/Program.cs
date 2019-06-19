using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_var2
{
    class Program
    {
        static void Main()
        {
            var junkMaterial = new Dictionary<string, int>();
            var keyMaterial = new Dictionary<string, int>();

            keyMaterial["shards"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["motes"] = 0;

            CollectMaterials(keyMaterial, junkMaterial);

            Console.WriteLine("{0} obtained",ObtainLegendaryItem(keyMaterial));
            PrintMaterials(keyMaterial.OrderByDescending(m => m.Value).ThenBy(m => m.Key));
            PrintMaterials(junkMaterial.OrderByDescending(m => m.Key));
        }
        


        private static void PrintMaterials(IOrderedEnumerable<KeyValuePair<string,int>> materials)
        {
            foreach(var material in materials)
            {
                Console.WriteLine(string.Format("{0} {1}",material.Key,material.Value));
            }
        }
        private static string ObtainLegendaryItem(Dictionary<string,int> keyMaterials)
        {
            var materialName = keyMaterials.Where(x => x.Value >= 250).First().Key;

            keyMaterials[materialName] -= 250;

            switch(materialName)
            {
                case "shards":
                    return "Shadowmourne";
                case "fragments":
                    return "Valanyr";
                case "motes":
                    return "Dragonwrath";
                default:
                    return "Big error";
            }
        }
        private static void CollectMaterials(Dictionary<string,int> keyMaterials,Dictionary<string,int> junkMaterials)
        {
            while(true)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for(int i = 0; i < input.Length; i++)
                {
                    var quantity = int.Parse(input[i]);
                    i++;

                    var material = input[i];

                    if(keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if(keyMaterials[material] >= 250)
                        {
                            return;
                        }
                    }

                    else
                    {
                        if(!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }
                        junkMaterials[material] += quantity;
                    }
                }
            }
        }
    }
}
