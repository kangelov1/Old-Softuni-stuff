using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class LeutenantGeneral:ILeutenantGeneral
    {
        private string id;
        private string firstName;
        private string lastName;
        private double salary;
        private List<string> underCommand;
        public List<string> UnderCommand
        {
            get { return this.underCommand; }
            private set { this.underCommand = value; }
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
            private set
            {
                this.lastName = value;
            }
        }

        public LeutenantGeneral(string id,string firstName,string lastName,double salary,params string [] listOfIDs)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            List<string> list = new List<string>();
            foreach(var entry in listOfIDs)
            {
                list.Add(entry);
            }
            this.UnderCommand = list;
        }
    }
}
