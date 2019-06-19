using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GoldenEditionBook:Book
{
    public override double Price
    {
        get
        {
            return base.Price * 1.3;
        }
        protected set
        {
            base.Price = value ;
        }
    }
    public GoldenEditionBook(string title, string author, double price) : base(title, author, price) { }
}

