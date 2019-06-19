using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Wild_Farm
{
    public abstract class Food
    {
        private int quantity;

        public int Quantity
        {
            get { return this.quantity; }
        }

        public Food(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
