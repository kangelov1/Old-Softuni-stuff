using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            protected set 
            {
                if(value < 0)
                {
                    throw new ArgumentException(string.Format("{0} needs refueling", this.GetType().Name));
                }
                //if(value > this.TankCapacity)
                //{
                //    throw new ArgumentException(string.Format("Cannot fit fuel in tank"));
                //}
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            protected set { this.fuelConsumption = value; }
        }

        public Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public abstract void Driving(double distance);
        public abstract void Refueling(double fuelAmount);
    }
}
