using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main()
        {
            //create a dictionary to store names and phone numbers
            Dictionary<string, string> dict = new Dictionary<string, string>();
            
            //get input from user
            string input = Console.ReadLine();
            
            while(input != "search")
            {
                var current = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                var key = current[0];
                if(!dict.ContainsKey(key))
                {
                    dict[key] = "";
                }
                dict[key] = current[1];
                input = Console.ReadLine();
            }

            if (input == "search")
            {
                while (input != "stop")
                {

                    input = Console.ReadLine();
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine("{0} {1}", input, dict[input]);
                    }
                    else
                    {
                        Console.WriteLine("Dictionary does not contain entry with key {0}", input);
                    }
                }
            }


            Console.Read();
        }
    }
}
