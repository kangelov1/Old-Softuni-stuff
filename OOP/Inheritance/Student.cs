using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student:Person
    {
        private string school;

        public string School
        {
            get { return this.school; }
            set { this.school = value; }
        }
    }
}
