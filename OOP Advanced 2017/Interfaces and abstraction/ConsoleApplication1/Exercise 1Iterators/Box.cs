using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box <T>:IComparable<Box<T>> where T:IComparable
{
    public Box()
    {
        this.Value = default(T);
    }
    public Box(T value)
    {
        this.Value = value;
    }
    public T Value { get; set; }
    public override string ToString()
    {
        return string.Format("{0}: {1}",typeof(T).FullName,this.Value);
    }

    public int CompareTo(Box<T> other)
    {
        return this.Value.CompareTo(other.Value);
    }
}

