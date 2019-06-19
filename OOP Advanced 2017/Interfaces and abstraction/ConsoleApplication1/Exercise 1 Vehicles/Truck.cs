using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Vehicles
{
    public class Truck:Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption,double tankCapacity) : base(fuelQuantity, fuelConsumption + 1.6,tankCapacity) { }
        public override void Driving(double distance)
        {
            this.FuelQuantity -= distance * this.FuelConsumption;
            Console.WriteLine("Truck travelled {0} km",distance);
        }

        public override void Refueling(double fuelAmount)
        {
            if(fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuelAmount * 0.95;
        }
    }
}
