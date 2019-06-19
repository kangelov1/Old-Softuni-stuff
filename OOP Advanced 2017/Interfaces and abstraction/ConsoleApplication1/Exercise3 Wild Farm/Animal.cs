using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Wild_Farm
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public string AnimalName
        {
            get { return this.animalName; }
        }
        public string AnimalType
        {
            get { return this.animalType; }
        }
        public double AnimalWeight
        {
            get { return this.animalWeight; }
        }
        public int FoodEaten
        {
            get { return this.foodEaten; }
            protected set
            {
                this.foodEaten = value;
            }
        }

        public abstract void makeSound();
        public abstract void Eat(Food food);
        public Animal(string animalType, string animalName, double animalWeight)
        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.animalWeight = animalWeight;
            this.foodEaten = 0;
        }

    }
}
