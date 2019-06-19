using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Family
    {
        private List<Person> members;
        public Family()
        {
            this.members = new List<Person>();
        }
        public void AddMember(Person familyMember)
        {
            this.members.Add(familyMember);
        }
        public Person OldestMember()
        {
            return this.members.OrderBy(x => x.Age).Last();
        }
    }
}
