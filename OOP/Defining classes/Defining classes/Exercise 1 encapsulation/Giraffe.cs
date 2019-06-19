using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Giraffe:Creature
{
    private string name;
    public override void setName(string newName)
    {
        this.name = newName;
    }

    public override string getName()
    {
        return this.name;
    }

    public override int setWeight(int newWeight)
    {
        throw new NotImplementedException();
    }
}

