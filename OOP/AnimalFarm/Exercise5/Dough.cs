using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    private double Weight
    {
        set
        {
            if(value > minWeight && value < maxWeight)
            {
                this.weight = value;
            }
            else
            {
                throw new ArgumentException("Dough should be in the range of 1 to 200 grams");
            }
        }
    }
    private string FlourType
    {
        set
        {
            if(value.ToLower() == "white" || value.ToLower() == "wholegrain")
            {
                this.flourType = value.ToLower();
            }

            else
            {
                throw new ArgumentException("Invalid type of dough");
            }
        }
    }
    private string BakingTechnique
    {
        set
        {
            if(value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
            {
                this.bakingTechnique = value.ToLower();
            }
            else
            {
                throw new ArgumentException("Invalid type of dough");
            }
        }
    }

    private const double caloriesPerGramBase = 2;
    private const double whiteFlourCaloriesModifier = 1.5;
    private const double wholegrainFlourCaloriesModifier = 1.0;
    private const double crispyCaloriesModifier = 0.9;
    private const double chewyCaloriesModifier = 1.1;
    private const double homemadeCaloriesModifier = 1.0;
    private const double minWeight = 1.0;
    private const double maxWeight = 200.0;

    public Dough(string flourType,string bakingTechnique,double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }
    public double GetCalories()
    {
        var baseCalories = this.weight * caloriesPerGramBase;

        switch(this.flourType)
        {
            case "white":
                baseCalories *= whiteFlourCaloriesModifier;
                break;
            case "wholegrain":
                baseCalories *= wholegrainFlourCaloriesModifier;
                break;
        }

        switch(this.bakingTechnique)
        {
            case "crispy":
                baseCalories *= crispyCaloriesModifier;
                break;
            case "chewy":
                baseCalories *= chewyCaloriesModifier;
                break;
            case "homemade":
                baseCalories *= homemadeCaloriesModifier;
                break;
        }
        return baseCalories;
    }
}

