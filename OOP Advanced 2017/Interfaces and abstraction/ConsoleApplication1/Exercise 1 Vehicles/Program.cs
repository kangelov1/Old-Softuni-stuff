using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car = new Car(100, 0.3);

            for(int i = 0; i < 2; i++)
            {
                var input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "Car":
                        var car = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        break;
                    case "Truck":
                        var truck = new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        break;
                    case "Bus":
                        var bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        break;
                }
            }
            

            var numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "Drive":
                        switch (commands[1])
                        {
                            case "Car":
                                try
                                {
                                    car.Driving(double.Parse(commands[2]));
                                    break;
                                }
                                catch(ArgumentException e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                            case "Truck":
                                try
                                {
                                    truck.Driving(double.Parse(commands[2]));
                                    break;
                                }
                                catch(ArgumentException e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                            default:
                                throw new ArgumentException("Invalid command");
                        }
                        break;
                    case "Refuel":
                        switch (commands[1])
                        {
                            case "Car":
                                try
                                {
                                    car.Refueling(double.Parse(commands[2]));
                                    break;
                                }
                                catch(ArgumentException e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                            case "Truck":
                                try
                                {
                                    truck.Refueling(double.Parse(commands[2]));
                                    break;
                                }
                                catch(ArgumentException e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                            default:
                                throw new ArgumentException("Invalid command");
                        }
                        break;
                    default:
                        throw new ArgumentException("Invalid command");
                }
            }
            Console.WriteLine("Car:{0:f2}",car.FuelQuantity);
            Console.WriteLine("Truck:{0:f2}",truck.FuelQuantity);
        }
    }
}
