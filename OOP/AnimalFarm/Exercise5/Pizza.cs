using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{
    private const int NameMaxLength = 15;
    private const int MinToppingsCount = 0;
    private const int MaxToppingsCount = 10;

    private string name;
    private int numberOfToppings;
    private Dough dough;
    private Queue<Topping> toppings;

    public Pizza(string name,int numberOfToppings)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.toppings = new Queue<Topping>();
    }
    public string Name
    {
        get { return this.name; }
        private set
        {
            if(value.Length > NameMaxLength || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid name");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public Dough Dough
    {
        set { this.dough = value; }
    }
    public int NumberOfToppings
    {
        get { return this.numberOfToppings; }
        private set
        {
            if(value < MinToppingsCount || value > MaxToppingsCount)
            {
                throw new ArgumentException("Invalid count of toppings");
            }
            else
            {
                this.numberOfToppings = value;
            }
        }
    }
    public void AddToppings(Topping topping)
    {
        this.toppings.Enqueue(topping);
        this.NumberOfToppings = this.toppings.Count;
    }

    public string GetCalories()
    {
        var totalCalories = this.dough.GetCalories() + this.toppings.Select(x => x.GetCalories()).Sum();
        string message = string.Format("{0} - {1} calories", this.Name, totalCalories);
        return message;
    }
}

