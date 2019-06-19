using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main()
        {
            //get two strings from user
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            //call a method to check if the two strings are exchangeable
            Console.WriteLine(AreExchangeable(str1,str2));
        }
        private static bool AreExchangeable(string str1,string str2)
        {
            bool areExchangeable = true;
            //get the length of the strings and assign them to strings shorter and longer
            string longer = str1;
            string shorter = str2;

            if(str1.Length < str2.Length)
            {
                longer = str2;
                shorter = str1;
            }

            //create a dictionary with key char and value char
            Dictionary<char, char> dict = new Dictionary<char, char>();
            for(int i = 0; i < shorter.Length; i++)
            {
                char charInShorter = shorter[i];
                char charInLonger = longer[i];

                if(!dict.ContainsKey(charInShorter))
                {
                    dict[charInShorter] = charInLonger;
                }

                if(dict[charInShorter] != charInLonger)
                {
                    areExchangeable = false;
                    
                }
            }
            for (int i = shorter.Length; i < longer.Length; i++)
            {
                char charInLonger = longer[i];
                if(!dict.ContainsValue(charInLonger))
                {
                    areExchangeable = false;
                }
            }

            if(str1.Length == str2.Length)
            {
                longer = str2;
                shorter = str1;
                Dictionary<char, char> dict2 = new Dictionary<char, char>();
                for (int i = 0; i < shorter.Length; i++)
                {
                    char charInShorter = shorter[i];
                    char charInLonger = longer[i];

                    if (!dict2.ContainsKey(charInShorter))
                    {
                        dict2[charInShorter] = charInLonger;
                    }

                    if (dict2[charInShorter] != charInLonger)
                    {
                        areExchangeable = false;

                    }
                }
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    char charInLonger = longer[i];
                    if (!dict2.ContainsValue(charInLonger))
                    {
                        areExchangeable = false;
                    }
                }
            }
            s
                return areExchangeable;
        }
    }
}
