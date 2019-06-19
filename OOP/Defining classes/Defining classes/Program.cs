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
            Dictionary<string, Car> listOfCars = new Dictionary<string,Car>();

            for(int i = 0; i < N;i++)
            {
                var input = Console.ReadLine().Split();

                string model = input[0];
                decimal fuelAmount = decimal.Parse(input[1]);
                decimal fuelConsumption = decimal.Parse(input[2]);
                listOfCars.Add(model, new Car(model, fuelAmount, fuelConsumption));
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                var input = command.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    listOfCars[input[1]].DriveCar(decimal.Parse(input[2]));
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                command = Console.ReadLine();
            }

            foreach(var car in listOfCars)
            {
                Console.WriteLine(car.Key + " " + car.Value.FuelAmount + " " + car.Value.DistanceTravelled);
            }
        }
    }

