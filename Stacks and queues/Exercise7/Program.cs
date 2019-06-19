using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesis = new Stack<char>();
            var isBalanced = true;

            for(int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                if(current == '[' || current == '(' || current == '{')
                {
                    parenthesis.Push(current);
                }
                if(current == ')')
                {
                    var previous = parenthesis.Pop();
                    if(previous == '(')
                    {
                        continue;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
                if (current == ']')
                {
                    var previous = parenthesis.Pop();
                    if (previous == '[')
                    {
                        continue;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
                if (current == '}')
                {
                    var previous = parenthesis.Pop();
                    if (previous == '{')
                    {
                        continue;
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isBalanced);
        }
    }
}
