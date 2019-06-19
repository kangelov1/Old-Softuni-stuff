using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Wild_Farm
{
    public abstract class Mammal:Animal
    {
        protected string livingRegion;

        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight) 
        {
            this.livingRegion = livingRegion;
        }



        public override void makeSound()
        {
            throw new NotImplementedException();
        }

        public override void Eat(Food food)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            string output = string.Format("{0} [{1} {2} {3} {4}]", this.GetType().Name, this.AnimalName, this.AnimalWeight, this.livingRegion, this.FoodEaten);
            return output;
        }
    }
}
