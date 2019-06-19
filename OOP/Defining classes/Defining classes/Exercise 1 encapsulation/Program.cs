using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Program
{
    static void Main()
    {
        //StockGrabber stockGrabber = new StockGrabber();

        //StockObserver observer1 = new StockObserver(stockGrabber);
        //stockGrabber.setIBMPrice(197.00);
        //stockGrabber.setaaplPrice(677.60);
        //stockGrabber.setgooglePrice(676.40);


        //StockObserver observer2 = new StockObserver(stockGrabber);
        //stockGrabber.setIBMPrice(197.00);
        //stockGrabber.setaaplPrice(677.60);
        //stockGrabber.setgooglePrice(676.40);
        //EnemyShipFactory factory = new EnemyShipFactory();
        //EnemyShip ship = null;

        //var input = Console.ReadLine();
        //ship = factory.makeEnemyShip(input);
        //doStuffEnemy(ship);

        Thread tr = new Thread(Print1);
        tr.Start();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(2);
        }
        Console.ReadLine();
    }
    public static void doStuffEnemy(EnemyShip anEnemyShip)
    {
        anEnemyShip.display();
        anEnemyShip.followHeroShip();
        anEnemyShip.enemyShipShoots();
    }
    static void Print1()
    {
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(1);
        }
    }
}
