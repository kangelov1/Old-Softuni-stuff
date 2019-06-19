using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box
{
    private double length;
    private double height;
    private double width;

    private double Length
    {
        set 
        { 
            if(value < 0)
            {
                throw new ArgumentException("Length can't be negative");
            }
            else
            {
                this.length = value;
            }
        }
    }
    private double Height
    {
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height can't be negative");
            }
            else
            {
                this.height = value;
            }
        }
    }
    private double Width
    {
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width can't be negative");
            }
            else
            {
                this.width = value;
            }
        }
    }

    public Box(double length,double width,double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double SurfaceArea()
    {
        return 2 * this.length * this.width + 2 * this.width * this.height + 2 * this.length * this.height;
    }
    public double LateralArea()
    {
        return 2 * this.length * this.height + 2 * this.width * this.height;
    }
    public double Volume()
    {
        return this.height * this.length * this.width;
    }
}

