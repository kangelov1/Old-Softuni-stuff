using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Wild_Farm
{
    public abstract class Felime:Mammal
    {
        public Felime(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion) { }

        public override void makeSound()
        {
            throw new NotImplementedException();
        }

        public override void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
