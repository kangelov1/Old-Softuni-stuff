using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_names
{
    public class Rebel:Nameable
    {
        private string name;
        public string Name
        {
            set
            {
                if (base.names.Contains(value))
                {
                    throw new ArgumentException("Name already used");
                }
                base.names.Add(value);
                this.name = value;
            }
        }
        public Rebel(string name)
        {
            this.Name = name;
        }
    }
}
