using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        MathOperations mo = new MathOperations();
        Console.WriteLine(mo.Add(2,3));
        Console.WriteLine(mo.Add(2.23,2.21,2.321));
        Console.WriteLine(mo.Add(2m,3m,2m));
    }
}

