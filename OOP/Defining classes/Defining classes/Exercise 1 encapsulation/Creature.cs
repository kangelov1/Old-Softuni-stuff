using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Creature
{
    protected string name;
    protected int weight;
    protected string sound;

    public abstract void setName(string newName);
    public abstract string getName();
    public abstract int setWeight(int newWeight);
}

