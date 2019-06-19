using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    public class Program
    {
        public static void Main()
        {

            var accounts = new Dictionary<int,BankAccount>();

            var input = Console.ReadLine();

            while(input != "End")
            {
                var commands = input.Split();
                var id = int.Parse(commands[1]);
                switch(commands[0])
                {
                    case "Create":
                        if(!accounts.ContainsKey(id))
                        {
                            accounts.Add(id,new BankAccount(id, 0));
                        }
                        else
                        {
                            Console.WriteLine("Account already exists");
                        }
                        break;
                    case "Deposit":
                        var amount = double.Parse(commands[2]);
                        if(!accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            accounts[id].Deposit(amount);
                        }
                        break;
                    case "Withdraw":
                        amount = double.Parse(commands[2]);
                        if (!accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            try
                            {
                                accounts[id].Withdraw(amount);
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "Print":
                        if (!accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            Console.WriteLine("AccountID{0}, balance{1:f2}",accounts[id].ID,accounts[id].Balance);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
