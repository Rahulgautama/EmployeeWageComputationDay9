using System;

namespace EmployeeWageComputationOops9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program using Oops Concept Day9");
            EmployeeAttendance employeeAttendance = new EmployeeAttendance();
            int empCheck = employeeAttendance.CheckEmpoyeeAttendacne();
            const int IS_FULL_TIME = 1;
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Empoyee is Present");
            }
            else
            {
                Console.WriteLine("Empoyee is Absent");
            }
        }
    }
}
