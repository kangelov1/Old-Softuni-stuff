using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < N; i++)
            {

                var input = Console.ReadLine().Split().ToArray();
                if(input == null)
                {
                    N += 1;
                    continue;
                }
                if(input.Length == 4)
                {
                    employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3]));
                }

                if (input.Length == 5)
                {
                    int num1;
                    bool res = int.TryParse(input[4],out num1);

                    if(res)
                    {
                        employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], num1));
                    }
                    else
                    {
                        employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3],input[4]));
                    }
                }
                else if(input.Length == 6)
                {
                    int num1;
                    int.TryParse(input[5], out num1);
                   
                    employees.Add(new Employee(input[0], double.Parse(input[1]), input[2], input[3], input[4],num1));
                }
            }
            //var result = employees.GroupBy(a => a.Department,a => a.Salary,(department,salary) => new {Department = department,Salary = salary.Average()});
            var result = employees.GroupBy(x => x.Department)
                                    .Select(gr => new {Name = gr.Key,AverageSalary = gr.Average(em => em.Salary),Employees = gr})
                                    .OrderByDescending(gr => gr.AverageSalary)
                                    .FirstOrDefault();
            foreach(var employee in result.Employees)
            {
                Console.WriteLine("{0} {1} {2}",employee.Name,employee.Position,employee.Salary);
            }
        }
    }
}
