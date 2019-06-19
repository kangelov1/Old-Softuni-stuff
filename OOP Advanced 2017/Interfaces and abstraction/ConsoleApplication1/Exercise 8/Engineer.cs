using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class Engineer:IEngineer
    {
        private IList<IRepair> repairs;
        private string corps;
        private string firstName;
        private string lastName;
        private string id;
        private double salary;
        public List<IRepair> Repairs
        {
            get { return this.repairs as List<IRepair>; }
        }

        public string Corps
        {
            get { return this.corps; }
            private set { this.corps = value; }
        }

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
        public Engineer(string id,string firstName,string lastName,double salary,string corps,IEnumerable<IRepair> repairs)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            this.repairs = new List<IRepair>(repairs);
        }
    }
}
