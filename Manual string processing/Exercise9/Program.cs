using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main()
        {
            //get banned words
            var banned = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //get text
            string input = Console.ReadLine();
            foreach(var word in banned)
            {
                string sub = new string('*',word.Length);
                input = input.Replace(word, sub);
            }
            Console.WriteLine(input);
        }
    }
}
