using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        var box1 = new Box<int>(2);
        var box2 = new Box<int>(3);
        var box3 = new Box<string>("this");

        Console.WriteLine(box1.CompareTo(box2));
    }
}

