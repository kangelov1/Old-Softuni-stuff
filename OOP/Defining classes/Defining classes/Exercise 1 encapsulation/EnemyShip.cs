using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class EnemyShip
{
    private string name;
    private double amtDamage;

    public string getName() { return this.name; }
    public void setName(string name)
    {
        this.name = name;
    }

    public double getDamage() { return this.amtDamage; }
    public void setDamage(double damage)
    {
        this.amtDamage = damage;
    }

    public void followHeroShip()
    {
        Console.WriteLine(this.name + " is following");
    }
    public void display()
    {
        Console.WriteLine(this.name + " is on the screen");
    }
    public void enemyShipShoots()
    {
        Console.WriteLine(this.name + " does " + getDamage() + " damage");
    }
}

