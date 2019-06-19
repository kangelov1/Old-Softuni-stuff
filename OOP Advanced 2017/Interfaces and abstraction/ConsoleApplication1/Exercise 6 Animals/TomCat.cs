using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_Animals
{
    public class TomCat:Cat
    {
        private const string gender = "male";
        public TomCat(string name,int age):base(name,age,gender){}
    }
}
