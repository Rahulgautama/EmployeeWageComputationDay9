using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationOops9
{
    class EmployeeDailyWage
    {
        int EMP_RAT_PER_HOUR;// = 20;
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 2;
        int empHour = 0;
        int empWage = 0;
        public EmployeeDailyWage(int emp_Rate_Per_Hours)
        {
            EMP_RAT_PER_HOUR=emp_Rate_Per_Hours;
        }
        
        public static int CalculateEmployeeWork()
        {
            Random random = new Random();
            int empCheck = random.Next(3);
            return empCheck;
        }
        public int CalculateWageFullTimePartTime()
        {
            int empCheck = CalculateEmployeeWork();
            if (empCheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHour = 4;
            }
            else
            {

                empHour = 0;
            }
            empWage = empHour * EMP_RAT_PER_HOUR;
            return empWage;
        }
    }
}
