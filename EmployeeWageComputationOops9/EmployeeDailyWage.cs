using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationOops9
{
    class EmployeeDailyWage
    {
        public int EMP_RATE_PER_HOUR;//= 20;
        public EmployeeDailyWage(int emp_Rate_Per_Hrs)
        {
            this.EMP_RATE_PER_HOUR = emp_Rate_Per_Hrs;
        }        
        public const int IS_Full_TIME = 1;
        public const int IS_PART_TIME = 2;
        public int CalculateEmployeeWageSwitchCase()
        {
            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
            switch (empCheck)
            {
                case IS_Full_TIME:
                    empHour = 8;
                    break;
                case IS_PART_TIME:
                    empHour = 4;
                    break;
                default:
                    empHour = 0;
                    break;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            return empWage;
        }
    }
}
