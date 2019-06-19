using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8.Interfaces
{
    public class Repair:IRepair
    {
        private string partName;
        private int hoursWorked;

        public string PartName
        {
            get { return this.partName; }
            private set { this.partName = value; }
        }

        public int HoursWorked
        {
            get { return this.hoursWorked; }
            private set { this.hoursWorked = value; }
        }
        public Repair(string partName,int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }
    }
}
