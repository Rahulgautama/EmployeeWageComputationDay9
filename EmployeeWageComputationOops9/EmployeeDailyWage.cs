using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationOops9
{
    class EmployeeDailyWage
    {

        
        public class CalculateEmployeeWage 
        {

            public  int[] CalculateEmployeeWageTotalHrsAMonth(int emp_Rate_Per_Hrs,int num_Working_Days,int max_HrS_In_Month)
            {
                int EMP_RATE_PER_HOUR = emp_Rate_Per_Hrs;// 20;
                int empHour = 0;
                int empWage = 0;
                int totalEmpWage = 0;
                int totalEmpHour = 0;
                int totalWorkingDays = 0;
                int totalWorkingHours = 0;
                int NUM_OF_WORKING_DAYS = num_Working_Days;//20;
                int MAX_HRS_IN_MONTH = max_HrS_In_Month;//100;               

                var data = new CheckEmpoyeeRandom();
                while (totalWorkingDays < NUM_OF_WORKING_DAYS && totalWorkingHours < MAX_HRS_IN_MONTH)
                {                    
                    totalWorkingDays++;
                    int empCheck = data.CheckRandomFullPartTime();
                    switch (empCheck)
                    {
                        case 1:
                            empHour = 8;
                            break;
                        case 2:
                            empHour = 4;
                            break;
                        default:
                            empHour = 0;
                            break;
                    }
                    totalEmpHour += empHour;
                    empWage = empHour * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                }
                int[] arrEmpWage = { totalWorkingDays, totalEmpHour, totalEmpWage };
                return arrEmpWage;
            }
            
        }
     }
}
