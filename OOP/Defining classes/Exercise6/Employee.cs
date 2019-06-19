﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;

        private string email;
        private int age;

        public string Name
        {
            get { return this.name; }
        }
        public double Salary
        {
            get { return this.salary; }
        }
        public string Position
        {
            get { return this.position; }
        }
        public string Department
        {
            get { return this.department; }
        }
        public string Email
        {
            get { return this.email; }
        }
        public int Age
        {
            get { return this.age; }
        }

        public Employee(string name,double salary,string position,string department,string email,int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }
        public Employee(string name, double salary, string position, string department) : this(name, salary, position, department, "n/a", -1) { }
        public Employee(string name, double salary, string position, string department, string email) : this(name, salary, position, department, email, -1) { }
        public Employee(string name, double salary, string position, string department, int age) : this(name, salary, position, department, "n/a", age) { }
    }
}
