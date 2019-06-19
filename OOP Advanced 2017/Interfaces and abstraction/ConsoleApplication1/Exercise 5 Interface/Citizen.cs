using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Interface
{
    public class Citizen:IIDCheckable,IBirthable,INameable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }
        public string ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public Citizen(string name,int age,string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Birthdate = birthdate;
        }

        public bool IsIdFake(string idEnding)
        {
            if(this.ID.EndsWith(idEnding))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Birthdate
        {
            get { return this.birthdate; }
            private set { this.birthdate = value; }
        }
    }
}
