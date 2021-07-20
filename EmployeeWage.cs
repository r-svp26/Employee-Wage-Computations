using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        // constants
        const int EMP_RATE_PER_HR = 20;
        const int MAX_WORKING_DAY = 20;

        // variables
        int totalWage = 0;
        int dailyWage = 0;
        int empHrs = 0;

        /// <summary>
        /// This method is used to evaluate the monthly wage of an employee.
        /// </summary>
        public void monthWage() 
        {
            for (int i=1; i<=MAX_WORKING_DAY; i++) {
                Random rd = new Random();
                int empCheck = rd.Next(0, 3);
                switch (empCheck)
                {
                    case 2:
                        empHrs = 8;
                        break;
                    case 1:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
            }
            dailyWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee monthly wage:" + (totalWage+dailyWage));
        }
    }
}
