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
            var mails = new Dictionary<string, string>();
            while(true)
            {
                var input = Console.ReadLine();
                if(input == "stop")
                {
                    break;
                }
                if(!mails.ContainsKey(input))
                {
                    mails[input] = null;
                }

                var eMail = Console.ReadLine();
                if(eMail.EndsWith("en") || eMail.EndsWith("us"))
                {
                    continue;
                }

                mails[input] = eMail;
            }

            foreach (KeyValuePair<string, string> kvp in mails)
            {
                if (kvp.Value != null)
                {
                    Console.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}