using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_Animals
{
    public abstract class Animal:ProducingSounds
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("invalid input");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if(value <= 0 || value == null)
                {
                    throw new ArgumentException("Invalid input");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            private set
            {
                if(value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("Invalid input");
                }
                this.gender = value;
            }
        }

        public Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}",this.GetType().Name,Environment.NewLine,this.Name,this.Age,this.Gender,this.ProduceSound());
        }
    }
}
