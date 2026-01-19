using System;

namespace LambdaAndLinq.EmployeeManagement
{
    public class Employee
    {
        public required string Name { get; set; }
        public required string Department { get; set; }
        public DateTime JoiningDate { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Department: {Department}, Joined: {JoiningDate:yyyy-MM-dd}";
        }
    }
}
