using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Wild_Farm
{
    public class Mouse:Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion):base(animalType, animalName, animalWeight, livingRegion){}

        public override void makeSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;
            if(foodName != "Vegetable")
            {
                throw new ArgumentException(string.Format("{0} are not eating that type of food",this.GetType().Name));
            }
            this.FoodEaten += food.Quantity;
        }
    }
}
