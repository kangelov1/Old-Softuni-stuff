using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    public class BankAccount
    {
        private int id;
        private double balance;


        public int ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Balance can't be negative");
                }
                this.balance = value;
            }
        }

        public BankAccount(int id, double balance) 
        {
            this.ID = id;
            this.Balance = balance;
        }

        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Amount to be deposited has to be bigger than 0");
            }
            this.Balance = this.Balance + amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance = this.Balance - amount;
        }

        public override string ToString()
        {
            return string.Format("Bank account:{0} Balance:{1}",this.ID,this.Balance);
        }
    }
}
