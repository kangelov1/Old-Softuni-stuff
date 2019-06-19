using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Interface
{
    public class Robot:IIDCheckable
    {
        private string model;
        private string id;

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }


        public string ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public Robot(string model,string id)
        {
            this.Model = model;
            this.ID = id;
        }
        public bool IsIdFake(string idEnding)
        {
            if(this.id.EndsWith(idEnding))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
