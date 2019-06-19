using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    private string title;
    private string author;
    private double price;

    public string Title
    {
        get { return this.title; }
        protected set 
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Not a valid title");
            }
            this.title = value; 
        }
    }
    public string Author
    {
        get { return this.author; }
        protected set
        {
            var input = value.Split();
            if(input.Length < 2 || char.IsDigit(input[1][0]))
            {
                throw new ArgumentException("Not a valid author name");
            }
            this.author = value;
        }
    }
    public virtual double Price
    {
        get { return this.price; }
        protected set 
        {
            if(value <= 0)
            {
                throw new ArgumentException("Price can't be negative");
            }
            this.price = value;
        }
    }

    public Book(string title,string author,double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type:").AppendLine(this.GetType().Name).Append("Title:").AppendLine(this.Title).Append("Author:").AppendLine(this.Author).Append("Price:").AppendLine(this.Price.ToString("f2"));
        return sb.ToString();
    }

}
