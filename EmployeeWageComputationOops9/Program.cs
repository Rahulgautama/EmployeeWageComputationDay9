using System;

namespace EmployeeWageComputationOops9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage");
            EmployeeDailyWage employeeDailyWage = new EmployeeDailyWage(20);
            int empWage=employeeDailyWage.CalculateEmployeeWageSwitchCase();
            Console.WriteLine("Employee Wage :" + empWage);
        }
    }
}
