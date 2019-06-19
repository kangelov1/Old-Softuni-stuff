using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5__2_
{
    using Factories;
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Eat(Console.ReadLine().Split().Where(fn => fn != string.Empty).Select(food => FoodFactory.GetFood(food)));
            Console.WriteLine(player);
        }
    }
}
