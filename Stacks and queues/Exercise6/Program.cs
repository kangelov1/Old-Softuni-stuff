using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> stations = new Queue<int[]>();
            for(int i = 0; i < n; i++)
            {
                stations.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            var helper = stations.ToArray();
            bool canMakeIt = true;
            int fuel = 0;
            int startIndex = 0;

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    fuel = fuel + helper[i][0] - helper[i][1];
                    if (fuel < 0)
                    {
                        canMakeIt = false;
                        fuel = 0;
                        stations.Enqueue(stations.Dequeue());
                        helper = stations.ToArray();
                        startIndex++;
                        break;
                    }
                    canMakeIt = true;
                }
                if(canMakeIt)
                {
                    break;
                }
            }


            if (canMakeIt)
            {
                Console.WriteLine(startIndex);
            }
            else
            {
                Console.WriteLine("No stations to start at");
            }

        }
    }
}
