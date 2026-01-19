using System;
using LambdaAndLinq.EmployeeManagement;
using LambdaAndLinq.StringProcessing;
using LambdaAndLinq.ProductManagement;

namespace LambdaAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1: Employee Filtering
            Console.WriteLine(" Employee Filtering");
            EmployeeFilter.Run();
           

            // // Task 2: String Sorting
            // Console.WriteLine(" String Sorting");
            // StringSorter.Run();

            // // Task 3: Product Grouping and Averaging
            // Console.WriteLine(" Product Grouping");
            // ProductGrouping.Run();

            Console.ReadKey();
        }
    }
}
