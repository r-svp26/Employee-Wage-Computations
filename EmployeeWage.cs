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
        /// This method is used to evaluate the daily wage of a part time employee also.
        /// </summary>
        public void dailyWage() 
        {
            Random rd = new Random();
            int empCheck = rd.Next(0, 3);
            if (empCheck == 2)
                empHrs = 8;
            else if (empCheck == 1)
                empHrs = 4;
            else
                empHrs = 0;
            totalWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee daily wage:" +totalWage);
        }
    }
}
