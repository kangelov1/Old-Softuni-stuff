using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        try
        {
            Topping topping = new Topping("meat", 30);
            Console.WriteLine(topping.GetCalories());
        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

