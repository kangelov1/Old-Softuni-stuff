using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '\n', '\r', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            
            string aInHex = string.Format("{0:X}",a);

            string aInBin = Convert.ToString(a, 2);
            if(aInBin.Length > 10)
            {
                aInBin.Substring(0, 10);
            }
            else if(aInBin.Length < 10)
            {
                aInBin = aInBin.PadLeft(10,'0');
            }

            Console.Write("|{0,-10}|",aInHex);
            Console.Write("{0,10}|",aInBin);

            string bInDecimal = string.Format("{0:0.00}", b);
            Console.Write("{0,10}|",bInDecimal);

            string cInDecimal = string.Format("{0:0.000}", c);
            Console.Write("{0,-10}|",cInDecimal);
        }
    }
}
