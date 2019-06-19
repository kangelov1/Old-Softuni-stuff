using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student:Human
{
    private string facultyNumber;

    private string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if(value.Length >=5 && value.Length <= 10)
            {
                bool test = true;
                for (int i = 0; i < value.Length; i++)
                {
                    test = char.IsLetterOrDigit(value[i]);
                }
                if(test)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number");
                }
            }
            else
            {
                throw new ArgumentException("Invalid faculty number");
            }
        }
    }
    public Student(string firstName,string lastName,string facultyNumber):base(firstName,lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("First Name:").AppendLine(base.FirstName).Append("Last Name:").AppendLine(base.LastName).Append("Faculty Number:").AppendLine(this.FacultyNumber).Append(Environment.NewLine);
        return sb.ToString();
    }
}

