﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cargo
{
    private int cargoWeight;
    private string cargoType;

    public string CargoType
    {
        get
        {
            return this.cargoType;
        }
    }

    public Cargo(int cargoWeight,string cargoType)
    {
        this.cargoWeight = cargoWeight;
        this.cargoType = cargoType;
    }
}

