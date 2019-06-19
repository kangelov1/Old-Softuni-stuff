using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Wild_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while(input != "End")
            {
                var values = input.Split();
                Animal animal;
                switch(values[0])
                {
                    case "Cat":
                        animal = new Cat(values[0], values[1], double.Parse(values[2]), values[3], values[4]);
                        break;
                    case "Tiger":
                        animal = new Tiger(values[0], values[1], double.Parse(values[2]), values[3]);
                        break;
                    case "Mouse":
                        animal = new Mouse(values[0], values[1], double.Parse(values[2]), values[3]);
                        break;
                    case "Zebra":
                        animal = new Zebra(values[0], values[1], double.Parse(values[2]), values[3]);
                        break;
                    default:
                        animal = null;
                        break;
                }
                var command = Console.ReadLine().Split();
                Food food;
                switch(command[0])
                {
                    case "Vegetable":
                        food = new Vegetable(int.Parse(command[1]));
                        break;
                    case "Meat":
                        food = new Meat(int.Parse(command[1]));
                        break;
                    default:
                        food = null;
                        break;
                }
                animal.makeSound();
                try
                {
                    animal.Eat(food);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(animal);
                input = Console.ReadLine();
            }
        }
    }
}
