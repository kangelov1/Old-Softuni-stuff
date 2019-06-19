using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class Private:IPrivate
    {
        private string id;
        private string firstName;
        private string lastName;
        private double salary;
        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public string ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public Private(string id,string firstName,string lastName,double salary)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }
    }
}
