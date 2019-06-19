using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_alt.Soldiers.Privates
{
    using Interfaces;
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private List<IPrivate> privateSoldiers;

        public LeutenantGeneral(string id, string firstName, string lastName, double salary, IEnumerable<IPrivate> privateSoldiers) 
            : base(id, firstName, lastName, salary)
        {
            this.privateSoldiers = new List<IPrivate>(privateSoldiers);
        }

        public IReadOnlyList<IPrivate> PrivateSoldiers
        {
            get
            {
                return this.privateSoldiers as IReadOnlyList<IPrivate>;
            }
        }

      
    }
}
