using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Lectrure
{
    public class Cat:Animal
    {
        public string Meow<T>(T element)
        {
            return element.ToString();
        }
    }
}
