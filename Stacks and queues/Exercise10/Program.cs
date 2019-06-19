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
            string text = "";
            //get number of operations from user
            int n = int.Parse(Console.ReadLine());

            //create a stack of commands
            Stack<string[]> commands = new Stack<string[]>();
            //create a stack of removed strings
            Stack<string> strings = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "1")
                {
                    text = text + input[1];
                    commands.Push(input);
                }
                else if (input[0] == "2")
                {
                    var count = int.Parse(input[1]);
                    string substring = text.Substring(text.Length - count);
                    strings.Push(substring);
                    text = text.Remove(text.Length - count);
                    commands.Push(input);
                }
                else if(input[0] == "3")
                {
                    var index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if(input[0] == "4")
                {
                    var current = commands.Pop();
                    if(current[0] == "1")
                    {
                        var length = current[1].Length;
                        text = text.Remove(text.Length - length);
                    }
                    else if(current[0] == "2")
                    {
                        text = text + strings.Pop();
                    }
                }
            }
            Console.Read();
        }


    }
}
