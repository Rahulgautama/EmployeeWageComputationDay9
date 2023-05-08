using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationOops9
{
    class EmployeeDailyWage
    {
        public static int[] CalculateEmpDailyWage(int emp_Rate_Per_Hrs)
        {
            int EMP_RAT_PER_HOUR = emp_Rate_Per_Hrs;
            int IS_FULL_TIME = 1;            

            int[] details = { EMP_RAT_PER_HOUR, IS_FULL_TIME};
            return details;
        }
        public void CalculateEmpWage()
        {
            var arr=CalculateEmpDailyWage(20);
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == arr[1])
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * arr[0];
            Console.WriteLine("Employee Wage :" + empWage);
        }
    }
}
