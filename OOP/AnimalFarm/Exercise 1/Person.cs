using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private int age;

    public virtual string Name
    {
        get { return this.name; }
        protected set
        {
            if(string.IsNullOrEmpty(value) || value.Length < 3)
            {
                throw new ArgumentException("Name can't be empty or less than 3 symbols");
            }
            this.name = value;
        }
    }
    public virtual int Age
    {
        get { return this.age; }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Age can't be negative");
            }
            this.age = value;
        }
    }
    public Person(string name,int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(string.Format("Name: {0} , Age: {1}", this.Name, this.Age));
        return stringBuilder.ToString();
    }
}

