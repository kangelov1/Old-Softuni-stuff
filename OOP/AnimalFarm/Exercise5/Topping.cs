using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Topping
{
    private string type;
    private double weight;

    private string Type
    {
        set
        {
            if(value.ToLower() == "meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce")
            {
                this.type = value.ToLower();
            }
            else
            {
                string exception = string.Format("Cannot place {0} on top of your pizza", value);
                throw new ArgumentException(exception);
            }
        }
    }
    private double Weight
    {
        set
        {
            if(value < minWeight || value > maxWeight)
            {
                string exception = string.Format("{0} has to be in the range of 1 to 50 grams", this.type);
                throw new ArgumentException(exception);
            }
            else
            {
                this.weight = value;
            }
        }
    }

    private const double caloriesPerGramBase = 2;
    private const double meatCaloriesModifier = 1.2;
    private const double veggiesCaloriesModifier = 0.8;
    private const double cheeseCaloriesModifier = 1.1;
    private const double sauceCaloriesModifier = 0.9;

    private const double minWeight = 1.0;
    private const double maxWeight = 50.0;
    public Topping(string type,double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }
    public double GetCalories()
    {
        var calories = this.weight * caloriesPerGramBase;

        switch(this.type)
        {
            case "meat":
                calories *= meatCaloriesModifier;
                break;
            case "veggies":
                calories *= veggiesCaloriesModifier;
                break;
            case "cheese":
                calories *= cheeseCaloriesModifier;
                break;
            case "sauce":
                calories *= sauceCaloriesModifier;
                break;
        }
        return calories;
    }
}

