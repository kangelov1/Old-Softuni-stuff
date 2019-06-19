using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            var cars = GetCars();
            //PrintCars(cars);
        }

        private static void PrintCars(Queue<Car> cars)
        {
            string input = Console.ReadLine();
            string output = string.Join(Environment.NewLine, cars.Where(c => c.Cargo.Type == input && input == "fragile" ? c.Tires.Where(t => t.Pressure < 1).FirstOrDefault() != null : c.Engine.Power > 250).Select(c => c.Model));
        }
        private static Queue<Car> GetCars()
        {
            var cars = new Queue<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            while(cars.Count < numberOfCars)
            {
                var input = Console.ReadLine().Split();
                //information about car in format
                //"Model EngineSpeed EnginePower CargoWeight CargoType Tire1Pressure Tire1Age Tire2Pressure Tire2Age Tire3Pressure Tire3Age Tire4Pressure Tire4Age
                string model = input[0];
                var engine = new Engine(int.Parse(input[1]),int.Parse(input[2]));
                var cargo = new Cargo(int.Parse(input[3]),input[4]);
                var tire = new Tire[]
                {
                    new Tire(int.Parse(input[6]),double.Parse(input[5])),
                    new Tire(int.Parse(input[8]),double.Parse(input[7])),
                    new Tire(int.Parse(input[10]),double.Parse(input[9])),
                    new Tire(int.Parse(input[12]),double.Parse(input[11]))
                };
                cars.Enqueue(new Car(model,engine,cargo,tire));
            }
            return cars;
        }
    }
}

        //private static HashSet<Person> GetPeople()
        //{
        //    var people = new HashSet<Person>();
        //    var numberOfPeople = int.Parse(Console.ReadLine());

        //    while(numberOfPeople > 0)
        //    {
        //        var personData = Console.ReadLine().Split();
        //        people.Add(new Person(personData[0],int.Parse(personData[1])));
        //        numberOfPeople--;
        //    }
        //    return people;
        //}
        //private static void PrintPeopleOlderThan30(HashSet<Person> people)
        //{
        //    IEnumerable<Person> filtered = people.Where();
        //}

   
