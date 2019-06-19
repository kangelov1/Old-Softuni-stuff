using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private string name;
    private double money;
    private List<Product> bagOfProducts;

    public string Name
    {
        get { return this.name; }
        private set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name can't be empty");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public double Money
    {
        get { return this.money; }
        private set
        {
            if(value < 0)
            {
                throw new ArgumentException("Money can't be negative");
            }
            else
            {
                this.money = value;
            }
        }
    }
    public List<Product> BagOfProducts
    { get { return this.bagOfProducts; } }

    public Person(string name,double money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<Product>();
    }

    public void BuyProduct(Product product)
    {
        this.Money = this.Money - product.Cost;
        Console.WriteLine("{0} bought {1}",this.Name,product.Name);
        this.bagOfProducts.Add(product);
    }
}

