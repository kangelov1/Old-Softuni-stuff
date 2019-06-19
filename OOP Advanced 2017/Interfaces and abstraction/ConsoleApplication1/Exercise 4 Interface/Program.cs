using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split().ToList();
            var webSites = Console.ReadLine().Split().ToList();

            try
            {
                Smartphone smartPhone = new Smartphone(phoneNumbers,webSites);
                smartPhone.Call();
                smartPhone.Browse();
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
