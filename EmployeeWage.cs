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
        const int MAX_WORKING_DAY = 20;
        const int MAX_HRS_IN_MONTH = 100;
        // variables
        int empHrs = 0;
        int totalMonthlyWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;

        /// <summary>
        /// This method is used to evaluate the monthly wage of an employee.
        /// </summary>
        public void MonthWage() 
        {
            while (totalEmpHrs < MAX_HRS_IN_MONTH &&
                    totalWorkingDays < MAX_WORKING_DAY) 
            {
                totalWorkingDays++;
                Random rd = new Random();
                int empCheck = rd.Next(0, 3);
                empHrs = empCheck switch
                {
                    IS_FULL_TIME => 8,
                    IS_PART_TIME => 4,
                    _ => 0,
                };
                totalEmpHrs += empHrs;
            }
            totalMonthlyWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total monthly wage:" +totalMonthlyWage);
        }
    }
}
