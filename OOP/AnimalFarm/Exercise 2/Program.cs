using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Title","Bill Evans",12.233);
        Console.WriteLine(book.ToString());
        GoldenEditionBook book2 = new GoldenEditionBook("Title", "Bill Evans", 12.233);
        Console.WriteLine(book2.ToString());
    }
}

