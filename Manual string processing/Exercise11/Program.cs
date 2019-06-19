using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main()
        {
            //get input from user and store as words in an array
            var input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            HashSet<string> palindromes = new HashSet<string>();
            //call a method on each word to check if its is a palindrome
            foreach (var word in input)
            {
                CheckIfPalindrome(word, palindromes);
            }
            foreach(var pal in palindromes.OrderBy(x => x))
            {
                Console.WriteLine(pal);
            }
        }

        static HashSet<string> CheckIfPalindrome(string word, HashSet<string> palindromes)
        {
            string test = word;

            Queue<char> letters = new Queue<char>();
            for (int i = test.Length - 1; i >= 0; i--)
            {
                letters.Enqueue(test[i]);
            }

            StringBuilder reversed = new StringBuilder();
            while (letters.Count > 0)
            {
                reversed.Append(letters.Dequeue());
            }
            string reverse = reversed.ToString();

            if(test == reverse)
            {
                palindromes.Add(word);
            }
            return palindromes;
        }
    }
}
