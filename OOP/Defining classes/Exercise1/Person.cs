using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Person
    {
        public string name;
        public int age;

        public Person():this("No name",1)
        {

        }
        public Person(int age):this("No name",age) 
        { 

        }
     
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",this.name,this.age);
        }
    }
}
