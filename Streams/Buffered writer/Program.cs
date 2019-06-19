using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Buffered_writer
{
    class BufferedWriter
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var fs = new FileStream("text.txt", FileMode.Create);

            using(fs)
            {
                for(int i = 0; i < 100000; i++)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(i.ToString());
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
            Console.WriteLine("Done:{0}",watch.Elapsed);
        }
    }
}
