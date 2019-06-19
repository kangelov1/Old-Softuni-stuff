using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Exercise3_Wild_Farm
{
    public class Zebra:Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion) { }
        public override void Eat(Food food)
        {
            var foodName = food.GetType().Name;
            if (foodName != "Vegetable")
            {
                throw new ArgumentException(string.Format("{0} are not eating that type of food", this.GetType().Name));
            }
            this.FoodEaten += food.Quantity;
        }

        public override void makeSound()
        {
            Console.WriteLine("Zs");
        }
    }

}
