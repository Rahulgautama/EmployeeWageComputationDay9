using System;
using static EmployeeWageComputationOops9.CompanyEmployeeDailyWage;

namespace EmployeeWageComputationOops9
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.AddCompanyEmpWage("DMart",20,2,10);
            empWageBuilderArray.AddCompanyEmpWage("Jio",10,4,20);

            empWageBuilderArray.ComputeEmpWage();
        }
    }
}
