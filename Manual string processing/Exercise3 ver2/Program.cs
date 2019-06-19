using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_ver2
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string aInHex = string.Format("{0:X}",a);
            Console.Write("|{0,-10}|",aInHex);

            string aInBinary = Convert.ToString(a, 2);
            Console.Write("{0,10}|",aInBinary.PadLeft(10,'0').Substring(0,10));

            string bInDec = string.Format("{0:0.00}", b);
            Console.Write("{0,10}|",bInDec);

            string cInDec = string.Format("{0:0.000}", c);
            Console.Write("{0,-10}|",cInDec);
        }
    }
}
