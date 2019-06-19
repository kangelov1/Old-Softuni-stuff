using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Book
{
    private int index;

    public string Title { get; private set; }
    public int Year { get; private set; }
    //public List<string> Authors { get; private set; }
    public Book(string title, int year)
    {
        this.Title = title;
        this.Year = Year;
        index += index;
    }
    public Book()
    {
        this.Title = "No title";
    }
}

