using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class Mission:IMission
    {
        private string codeName;
        private string state;

        public string CodeName
        {
            get { return this.codeName; }
            private set
            {
                this.codeName = value;
            }
        }

        public string State
        {
            get { return this.state; }
            private set
            {
                if (value != "inProgress" || value != "Finished")
                {
                    throw new ArgumentException("Invalid mission state");
                }
                this.state = value;
            }
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }
        public Mission(string codeName,string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
    }
}
