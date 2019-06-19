using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rectangle:Shape
{
    private double height;
    private double width;

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }
    public override double CalculatePerimeter()
    {
        return 2 * this.Width + 2 * this.Height;
    }
}

