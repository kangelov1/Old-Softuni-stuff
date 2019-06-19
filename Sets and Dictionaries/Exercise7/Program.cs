using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main()
        {
            //create a dictionary to store names and emails
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while(true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                if(!dict.ContainsKey(name))
                {
                    dict[name] = "";
                }
                string mail = Console.ReadLine();
                dict[name] = mail;
            }
            string test = string.Join(Environment.NewLine,dict.Where((x => !x.Value.EndsWith("us"))).Select(x => string.Format("{0} -> {1}",x.Key,x.Value)));
            Console.WriteLine(test);
        }
    }
}
