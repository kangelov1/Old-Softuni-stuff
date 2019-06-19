using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculates_sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> seq = new Queue<int> ();
            Console.WriteLine("Enter number: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write(N + " "); ;// Store number in first position in queue
            int current = N;
            for (int i = 0; i < 10; i++)
            {
                seq.Enqueue(current + 1);
                seq.Enqueue(2 * current + 1);
                seq.Enqueue(current + 2);
                current = seq.Dequeue();
                Console.Write(current + " ");
            }
        }
    }
}
