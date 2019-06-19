using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_classes
{
    public class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private decimal distanceTravelled;

        public decimal DistanceTravelled
        {
            get { return this.distanceTravelled; }
        }

        public decimal FuelAmount
        {
            get { return this.fuelAmount; }
            private set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Not enough fuel");
                }
                else
                {
                    this.fuelAmount = value;
                }
            }
        }
 
        public Car(string model,decimal fuelAmount,decimal fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distanceTravelled = 0;
        }

        public void DriveCar(decimal distance)
        {
            this.FuelAmount = this.FuelAmount - distance * this.fuelConsumption;
            this.distanceTravelled = this.distanceTravelled + distance;
        }
    }
}
