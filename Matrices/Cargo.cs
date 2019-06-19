using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Cargo
    {
        private int weight;
        private string type;

        public int Weight
        {
            get { return this.weight; }
        }
        public string Type
        {
            get { return this.type; }
        }
        public Cargo(int weight,string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
}
