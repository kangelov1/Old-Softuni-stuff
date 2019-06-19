using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Lectrure
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> test = new Scale<int>();
            test.Compare(2, 2);
        }
    }
}
