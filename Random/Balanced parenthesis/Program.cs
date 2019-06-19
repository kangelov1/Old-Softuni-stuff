using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = new char [input.Length];
            for (int i = 0; i < input.Length;i++)
            {
                array[i] = input[i];
            }

            Stack<char> helper = new Stack<char>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '(' || array[i] == '{' || array[i] == '[')
                {
                    helper.Push(array[i]);
                }
                if (array[i] == ')')
                {

                    char temp = (char)((int) array[i] - 1);
                    if(temp == helper.Peek())
                    {
                        helper.Pop();
                    }
                    else if (temp != helper.Peek())
                    {
                        Console.WriteLine("No");
                        break;
                    }
                }
                if ( array[i] == '}' || array[i] == ']')
                {

                    char temp = (char)((int)array[i] - 2);
                    if (temp == helper.Peek())
                    {
                        helper.Pop();
                    }
                    else if (temp != helper.Peek())
                    {
                        Console.WriteLine("No");
                        break;
                    }
                }
                if (helper.Count == 0)// if first bracket is closing it will say yes - FIX IT
                {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}
