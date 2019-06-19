using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var input2 = Console.ReadLine().Split();



        try
        {
            Student student = new Student(input[0], input[1], input[2]);
            Console.WriteLine(student.ToString());
        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Worker worker = new Worker(input2[0], input2[1], double.Parse(input2[2]), int.Parse(input2[3]));
            Console.WriteLine(worker.ToString());
        }
        catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

