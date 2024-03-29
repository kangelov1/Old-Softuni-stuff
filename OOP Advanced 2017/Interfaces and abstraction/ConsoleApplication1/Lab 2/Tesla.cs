﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Tesla:ICar,IElectricCar
    {
        private string model;
        private string color;
        private int battery;
        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string Color
        {
            get { return this.color; }
            private set { this.color = value; }
        }
        public Tesla(string model,string color,int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak";
        }

        public int Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} {1} {2} with {3} batteries", this.Color, this.GetType().Name, this.Model,this.Battery)).AppendLine(this.Start()).AppendLine(this.Stop());
            return sb.ToString();
        }
    }
}
