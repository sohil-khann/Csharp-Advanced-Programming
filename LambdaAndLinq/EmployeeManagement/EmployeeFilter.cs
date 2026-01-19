using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAndLinq.EmployeeManagement
{
    public class EmployeeFilter
    {
        public static void Run()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Sohil", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-2) },
                new Employee { Name = "Raj", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-5) },
                new Employee { Name = "Ravi", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-8) },
                new Employee { Name = "Sai", Department = "Finance", JoiningDate = DateTime.Now.AddMonths(-1) },
                new Employee { Name = "tanuj", Department = "IT", JoiningDate = DateTime.Now.AddMonths(-3) },
                new Employee { Name = "Ram", Department = "HR", JoiningDate = DateTime.Now.AddMonths(-10) }
            };

            string targetDepartment = "IT";
            DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);

            // Filter employees who joined in the last six months and are from a specific department
            List<Employee> filteredEmployees=employees.Where(x=>x.Department==targetDepartment && x.JoiningDate>=sixMonthsAgo).ToList();

           
            Console.WriteLine($" Employees in {targetDepartment} who joined in the last 6 months ");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
