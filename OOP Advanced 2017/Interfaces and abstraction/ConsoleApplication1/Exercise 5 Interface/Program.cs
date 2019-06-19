using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> listOfBirthables = GetBirthdays();
            string requiredBirthYear = Console.ReadLine();

            foreach(var entry in listOfBirthables)
            {
                var year = entry.Birthdate.Split(new char[] {'/'})[2];
                if(year == requiredBirthYear)
                {
                    Console.WriteLine(entry.Birthdate);
                }
            }
        }
        private static List<IBirthable> GetBirthdays()
        {
            List<IBirthable> listOfBirthable = new List<IBirthable>();
            var input = Console.ReadLine();

            while(input != "End")
            {
                var commands = input.Split();
                switch(commands[0])
                {
                    case "Citizen":
                        listOfBirthable.Add(new Citizen(commands[1],int.Parse(commands[2]),commands[3],commands[4]));
                        break;
                    case "Robot":
                        break;
                    case "Pet":
                        listOfBirthable.Add(new Pet(commands[1],commands[2]));
                        break;
                }
                input = Console.ReadLine();
            }
            return listOfBirthable;
        }
        private static void GetIIdentifiable()
        {
            List<string> fakeIDs = new List<string>();
            List<IIDCheckable> listOfEntries = new List<IIDCheckable>();


            var input = Console.ReadLine();
            while (input != "End")
            {
                var commands = input.Split();
                switch (commands.Length)
                {
                    case 2:
                        IIDCheckable robot = new Robot(commands[0], commands[1]);
                        listOfEntries.Add(robot);
                        break;
                    case 4:
                        IIDCheckable citizen = new Citizen(commands[0], int.Parse(commands[1]), commands[2], commands[3]);
                        listOfEntries.Add(citizen);
                        break;
                }
                input = Console.ReadLine();
            }

            var idEnding = Console.ReadLine();

            foreach (var entry in listOfEntries)
            {
                bool isFakeId = entry.IsIdFake(idEnding);
                if (isFakeId)
                {
                    Console.WriteLine(entry.ID);
                }
            }
        }
    }
}
