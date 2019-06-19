using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class  Book
    {
        private string title;
        private string author;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public Book()
        {
            Title = "Default title";
            Author = "John Doe";
        }

        public override string ToString()
        {
            string text = null;
            text += "Title:" + Title;
            text += "Author:" + Author;

            return text;
        } 

        //public static void Exercise1()
        //{
        //    int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
        //    int rows = input[0];
        //    int columns = input[1];
        //    //print 1 row with columns
        //    char outer = 'a';
        //    char middle = outer;
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < columns; j++)
        //        {
        //            Console.Write("{0}{1}{0} ", outer.ToString(), middle.ToString(), outer.ToString());
        //            middle = Convert.ToChar((Convert.ToInt32(middle)) + 1);
        //        }
        //        outer = Convert.ToChar(Convert.ToInt32(outer) + 1);
        //        middle = outer;
        //        Console.WriteLine();
        //    }
        //    Console.Read();
        //}
        //private static int CountEqualSquares(char[][] matrix)
        //{
        //    var count = 0;
        //    for(int i = 0; i < matrix.Length - 1; i++)
        //    {
        //        for(int j = 0; j < matrix[i].Length - 1; j++)
        //        {
        //            if(matrix[i][j] == matrix[i][j +1] &&
        //                matrix[i][j] == matrix[i + 1][j]&&
        //                matrix[i][j] == matrix [i + 1][j+1])
        //            {
        //                count++;
        //            }
        //        }
        //    }
        //    return count;
        //}
        //private static char[][] InitializeMatrix()
        //{
        //    var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //    var matrix = new char [dimensions[0]][];

        //    for(int i = 0; i < matrix.Length; i++)
        //    {
        //        matrix [i] = Console.ReadLine().ToCharArray().Where(c => c != ' ').ToArray();
        //    }
        //    return matrix;
        //}
    }
}
