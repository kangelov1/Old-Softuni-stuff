using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Worker:Human
{
    private double weekSalary;
    private int workHoursPerDay;
    private double hourlyRate;

    private double WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if(value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            else
            {
                this.weekSalary = value;
            }
        }
    }
    private int WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if(value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }
    private double HourlyRate
    {
        get { return this.hourlyRate; }
        set
        {
            this.hourlyRate = value;
        }
    }
    public Worker(string firstName,string lastName,double weekSalary,int workHoursPerDay):base(firstName,lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
        this.HourlyRate = weekSalary / (workHoursPerDay * 5);
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("First Name:").AppendLine(base.FirstName).Append("Last Name:").AppendLine(base.LastName).Append("Week Salary:").AppendLine(this.WeekSalary.ToString("f2")).Append("Hours per day:").AppendLine(this.WorkHoursPerDay.ToString("f2")).Append("Salary per day:").AppendLine(this.HourlyRate.ToString("f2"));
        return sb.ToString();
    }
}

