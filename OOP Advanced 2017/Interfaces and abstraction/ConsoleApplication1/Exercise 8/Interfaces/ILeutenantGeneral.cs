using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    interface ILeutenantGeneral:IPrivate
    {
        List<string> UnderCommand { get; }
    }
}
