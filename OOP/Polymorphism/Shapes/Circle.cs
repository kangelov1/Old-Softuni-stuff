using System;
public class Circle:Shape
{
    private double radius;
    public double Radius
    {
        get{return this.radius;}
        set{this.radius = value;}
    }
    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.radius * this.radius;
    }

    public override double CalculatePerimeter()
    {
        return Math.PI * this.radius * 2;
    }

    public override string Draw()
    {
        return "Drawing circle";
    }



}

