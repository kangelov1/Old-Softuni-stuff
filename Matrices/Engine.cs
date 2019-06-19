using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Engine
    {
        private int speed;
        private int power;

        public int Speed
        {
            get { return this.speed; }
        }
        public int Power
        {
            get { return this.power; }
        }

        public Engine(int speed,int power)
        {
            this.speed = speed;
            this.power = power;
        }
    }
}
