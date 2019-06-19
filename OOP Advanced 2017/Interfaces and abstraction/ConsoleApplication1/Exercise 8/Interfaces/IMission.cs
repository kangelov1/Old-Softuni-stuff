using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    interface IMission
    {
        string CodeName { get; }
        string State { get; }
        void CompleteMission();
    }
}
