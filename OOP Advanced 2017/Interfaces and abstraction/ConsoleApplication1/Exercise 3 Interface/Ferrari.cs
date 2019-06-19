using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_Interface
{
    public class Ferrari:ICar
    {
        private const string model = "488 - Spider";
        private string driver;
        private string Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }

        public string Brake()
        {
            return "Brakes";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA";
        }
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }
        public override string ToString()
        {
            return string.Format("{0}/{2}/{3}/{1}",model,this.Driver,this.Brake(),this.PushGasPedal());
        }

    }
}
