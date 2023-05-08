using System;
using static EmployeeWageComputationOops9.EmployeeDailyWage;

namespace EmployeeWageComputationOops9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage");
            CalculateEmployeeWage employeeDailyWage = new CalculateEmployeeWage();
            var detail=employeeDailyWage.CalculateEmployeeWageTotalHrsAMonth(20,20,100);

            Console.WriteLine("Total Working Days: " + detail[0]);
            Console.WriteLine("Total Working Hours: " + detail[1]);
            Console.WriteLine("Total Employee Wage : " + detail[2]);
        }
    }
}
