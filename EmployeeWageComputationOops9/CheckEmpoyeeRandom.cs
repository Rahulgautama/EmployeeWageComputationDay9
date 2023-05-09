using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationOops9
{
    public class CheckEmpoyeeRandom
    {
        public int CheckRandomFullPartTime()
        {
            Random rdm = new Random();
            int empCheck = rdm.Next(3);
            return empCheck;
        }
    }
}
