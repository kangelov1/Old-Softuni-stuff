using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        public static Cat cat2;
        static void Main(string[] args)
        {
            cat2 = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Goshko", "Meso");
            Animal cat = new Cat("Ivan", "Java");

            var listOfAnimals = new List<Animal>();
            listOfAnimals.Add(dog);
            listOfAnimals.Add(cat);

            Print(listOfAnimals);
            
        }

        public static void Print(List<Animal> animals)
        {
            foreach(var animal in animals)
            {
                Console.WriteLine(animal.ExplainMyself());
            }
        }
    }

