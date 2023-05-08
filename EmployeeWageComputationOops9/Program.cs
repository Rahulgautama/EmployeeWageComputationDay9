using System;

namespace EmployeeWageComputationOops9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage");
            EmployeeDailyWage employeeDailyWage = new EmployeeDailyWage(20);
            int empWage=employeeDailyWage.CalculateWageFullTimePartTime();

            Console.WriteLine("Employee Wage :" + empWage);

        }
    }
}
