using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    private string name;
    private string favoriteFood;

    public string Name { get { return this.name; } }
    public string FavoriteFood { get { return this.favoriteFood; } }

    public Animal(string name,string favoriteFood)
    {
        this.name = name;
        this.favoriteFood = favoriteFood;
    }
    public virtual string ExplainMyself()
    {
        return "";
    }
}

