using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Lectrure
{
    public class Scale<T>
        where T:IComparable
    {
        public void Compare(T first, T second)
        {
            if(first.CompareTo(second)>0)
            {

            }
        }
    }
}
