using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_ver2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var performanceData = Console.ReadLine().Trim();

                var indexOfSeparation = performanceData.IndexOf("@");
                if (indexOfSeparation < 1)
                {
                    continue;
                }

                var indexOfTicketPrice = IndexOfTicketPrice(performanceData, indexOfSeparation);
                if(indexOfTicketPrice < 0 || performanceData[indexOfTicketPrice - 1] != ' ')
                {
                    continue;
                }

                var indexOfTicketAmount = performanceData.LastIndexOf(' ');
                if(indexOfTicketAmount < indexOfTicketPrice + 1)
                {
                    continue;
                }

                var singer = performanceData.Substring(0, indexOfSeparation);
                var town = performanceData.Substring(indexOfSeparation + 2,);
            }
        }

        private static int IndexOfTicketPrice(string performanceData,int index)
        {
            for(int i = performanceData.Length - 1; i >= index; i--)
            {
                if(char.IsLetter(performanceData[i]))
                {
                    return i + 2;
                }
            }

            return -1;
        }
    }
}
