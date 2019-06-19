using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Vehicles
{
    public class Bus:Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity) { }
        public override void Refueling(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + fuelAmount > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            this.FuelQuantity += fuelAmount;
        }
        public override void Driving(double distance,bool full)
        {
            switch(full)
            {
                case false:
                    this.FuelQuantity = this.FuelQuantity - distance * this.FuelConsumption;
                    Console.WriteLine("Car travelled {0} km",distance);
                    break;
                case true:
                    this.FuelQuantity = this.FuelQuantity - distance * (this.FuelConsumption + 1.4);
                    Console.WriteLine("Car travelled {0} km",distance);
                    break;
            }
            throw new NotImplementedException();
        }
    }
}
