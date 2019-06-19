using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    private string name;
    private double cost;
    public double Cost
    {
        get { return this.cost; }
    }
    public string Name
    {
        get { return this.name; }
    }

    public Product(string name,double cost)
    {
        this.name = name;
        this.cost = cost;
    }
}

