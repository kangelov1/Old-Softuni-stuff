using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Wild_Farm
{
    public class Cat:Felime
    {
        private string breed;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalType, animalName, animalWeight, livingRegion) 
        {
            this.breed = breed;
        }

        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            string output = string.Format("{0} [{1} {5} {2} {3} {4}]", this.GetType().Name, this.AnimalName, this.AnimalWeight, this.livingRegion, this.FoodEaten,this.breed);
            return output;
        }
    }
}
