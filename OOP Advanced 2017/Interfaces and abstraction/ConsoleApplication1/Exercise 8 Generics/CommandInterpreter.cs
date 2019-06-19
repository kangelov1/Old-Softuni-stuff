using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CommandInterpreter
{
    public void ReadCommands()
    {
        var customList = new CustomList<string>();

        var command = Console.ReadLine().Split().ToArray();

        while (command[0] != "END")
        {
            switch (command[0])
            {
                case "Add":
                    customList.Add(command[1]);
                    break;
                case "Remove":
                    customList.Remove(int.Parse(command[1]));
                    break;
                case "Contains":
                    Console.WriteLine(customList.Contains(command[1]));
                    break;
                case "Swap":
                    customList.Swap(int.Parse(command[1]), int.Parse(command[2]));
                    break;
                case "Greater":
                    Console.WriteLine(customList.CountGreaterThan(command[1]));
                    break;
                case "Max":
                    Console.WriteLine(customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(customList.Min());
                    break;
                case "Print":
                    foreach(var entry in customList.Values)
                    {
                        Console.WriteLine(entry);
                    }
                    break;
            }
            command = Console.ReadLine().Split().ToArray();
        }
    }
}

