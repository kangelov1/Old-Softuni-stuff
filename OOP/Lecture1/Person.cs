using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name,int age,List<BankAccount> accounts):this(name,age)
        {
            this.accounts = accounts;
        }
        public double GetBalance()
        {
            return this.accounts.Select(a => a.Balance).Sum();
        }
    }
}
