using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal> { new Animal { Name = "Barley", Age = 8.3 }, new Animal { Name = "Boots", Age = 4.9 }, new Animal { Name = "Whiskers", Age = 1.5 }, new Animal { Name = "Daisy", Age = 4.3 } };
            var query = animalList.GroupBy(x => Math.Floor(x.Age), x => x.Age, (baseAge, ages) => new { Key = baseAge, Count = ages.Count(), Min = ages.Min(), Max = ages.Max() });        
        }

        class Animal
        {
            public string Name;
            public double Age;
            public Animal() { }
        }
    }
}
