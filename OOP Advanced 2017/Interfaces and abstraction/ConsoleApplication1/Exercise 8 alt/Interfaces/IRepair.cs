using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_alt.Interfaces
{
    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}
