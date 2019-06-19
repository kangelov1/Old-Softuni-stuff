using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Person person = new Person("Bill", 10);
        Child child = new Child("Bill", 10);
        Console.WriteLine(person.ToString());
        Console.WriteLine(child.ToString());
    }
}
