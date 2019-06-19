using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_tour
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number of stations from user
            Console.WriteLine("Enter number of stations");
            int N = int.Parse(Console.ReadLine());
            Queue<Station> queue = new Queue<Station>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter distance to next station and fuel capacity: ");
                string input = Console.ReadLine();
                string[] values = input.Split(' ');
                Station current = new Station();
                current.distance = Convert.ToInt32(values[0]);
                current.fuelCapacity = Convert.ToInt32(values[1]);
                queue.Enqueue(current);
            }

            int resultIndex = 0;
            bool solutionFound = false;

            while(true)
            {
                Station startStation = queue.Dequeue();// take first station in queue
                queue.Enqueue(startStation);// place first station at last place, so that to keep the circle

                int fuel = startStation.fuelCapacity;//get fuel capacity from first station
                fuel = fuel - startStation.distance;//remaining fuel after "travelling" to second station

                int currentStationCount = 1;// store index of starting point

                while(fuel >= 0) // check if fuel is enough to reach next station
                {
                    Station currentStation = queue.Dequeue();//proceed with next station
                    if(currentStation == startStation)
                    {
                        Console.WriteLine("solution found");
                        Console.WriteLine("start at station {0}",currentStationCount);
                        break;
                    }

                    fuel = fuel + currentStation.fuelCapacity - currentStation.distance;
                    queue.Enqueue(currentStation);
                    currentStationCount++;
                }
                break;
            }
         
        }
    }
}
