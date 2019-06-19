using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CustomList<T> where T:IComparable
{
    public List<T> Values { get; set; }
    public CustomList()
    {
        this.Values = new List<T>();
    }
    public void Add(T element)
    {
        this.Values.Add(element);
    }
    public T Remove(int index)
    {
        var res = this.Values[index];
        this.Values.RemoveAt(index);
        return res;
    }
    public bool Contains(T element)
    {
        bool res = false;
        int isEqual = -1;

        foreach(var item in this.Values)
        {
            if(item.CompareTo(element) == 0)
            {
                isEqual = 0;
                break;
            }
        }
        if(isEqual == 0)
        {
            res = true;
        }
        return res;
    }
    public void Swap(int index1,int index2)
    {
        T temp = this.Values[index1];
        this.Values[index1] = this.Values[index2];
        this.Values[index2] = temp;
    }
    public int CountGreaterThan(T element)
    {
        int count = 0;
        foreach(var item in this.Values)
        {
            if(item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }
    public T Max()
    {
        T currentBiggest = this.Values[0];

        for(int i = 0; i < this.Values.Count - 1; i++)
        {
            if (this.Values[i].CompareTo(this.Values[i + 1]) < 0)
            {
                currentBiggest = this.Values[i + 1];
            }
        }
        return currentBiggest;
    }
    public T Min()
    {
        T currentSmallest = this.Values[0];

        for (int i = 0; i < this.Values.Count - 1; i++)
        {
            if (this.Values[i].CompareTo(this.Values[i + 1]) > 0)
            {
                currentSmallest = this.Values[i + 1];
            }
        }
        return currentSmallest;
    }
}

