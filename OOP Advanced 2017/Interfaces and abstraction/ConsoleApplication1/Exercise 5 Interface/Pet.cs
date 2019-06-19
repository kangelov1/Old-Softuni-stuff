using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Interface
{
    public class Pet:IBirthable,INameable
    {

        public string Birthdate
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
        public Pet(string name,string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
