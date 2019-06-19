using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        List<Car> listOfCars = new List<Car>();

        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Split();
            listOfCars.Add(new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4], double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]), double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]), int.Parse(input[12])));
        }
        
        var command = Console.ReadLine();
        if(command == "fragile")
        {
            var result = listOfCars.Where(x => x.Cargo.CargoType == command).Where(x => x.Tires.Any(t => t.Pressure < 1)).Select(c => c.Model).ToList();

            foreach (var model in result)
            {
                Console.WriteLine(model);
            }
        }
        else if(command == "flamable")
        {
            var result = listOfCars.Where(x => x.Cargo.CargoType == command).Where(x => x.Engine.EnginePower > 250).Select(c => c.Model).ToList();

            foreach (var model in result)
            {
                Console.WriteLine(model);
            }
        }
    }
}

