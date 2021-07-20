using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        // constants
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int EMP_RATE_PER_HR = 20;

        // variables
        int totalWage = 0;
        int empHrs = 0;

        /// <summary>
        /// In this method we have used the switch statement to evaluate daily wage of an employee.
        /// </summary>
        public void dailyWage() 
        {
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
            totalWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee daily wage:" +totalWage);
        }
    }
}
