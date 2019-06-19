using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson citizen = new Citizen("Pesho", 20,"no id","unknown");
            IIdentifiable citizen2 = new Citizen("Pesho", 20, "no id", "unknown");
            Console.WriteLine("");
        }
    }
}
