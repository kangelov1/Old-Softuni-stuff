using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Vehicles
{
    public class Car:Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption,double tankCapacity) : base(fuelQuantity, fuelConsumption + 0.9,tankCapacity) { }
        public override void Driving(double distance)
        {
            this.FuelQuantity = this.FuelQuantity - distance * this.FuelConsumption;
            Console.WriteLine("Car travelled {0} km",distance);
        }

        public override void Refueling(double fuelAmount)
        {
            if(fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if(this.FuelQuantity + fuelAmount > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.FuelQuantity += fuelAmount;
        }
    }
}
