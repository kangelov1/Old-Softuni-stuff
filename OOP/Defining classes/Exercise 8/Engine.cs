﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private int engineSpeed;
    private int enginePower;
    public int EnginePower
    {
        get { return this.enginePower; }
    }

    public Engine(int engineSpeed,int enginePower)
    {
        this.engineSpeed = engineSpeed;
        this.enginePower = enginePower;
    }
}

