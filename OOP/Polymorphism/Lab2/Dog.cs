using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Dog:Animal
{
    public Dog(string name, string favoriteFood) : base(name, favoriteFood) { }
    public override string ExplainMyself()
    {
        var sb = new StringBuilder();
        string line1 = string.Format("I am {0} and my favorite food is {1}", base.Name, base.FavoriteFood);
        sb.AppendLine(line1).AppendLine("Woof");
        return sb.ToString();
    }
}

