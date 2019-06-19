using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Lectrure
{
    public static class ArrayCreator<T>
    {
        public static T[] Create<T>(int length,T item)
        {
            return new T[length];
        }
    }
}
