﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle:Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    public override double CalculatePerimeter()
    {
        return this.height * 2 + this.width * 2;
    }
    public override double CalculateArea()
    {
        return this.height * this.width;
    }
    public override string Draw()
    {
        return base.Draw() + "rectangle";
    }
}

