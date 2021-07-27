using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        // constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        
        // variables
        static int empHrs = 0;
        static int totalEmpHrs = 0;
        static int totalWorkingDays = 0;
        static int totalEmpWage = 0;
        /// <summary>
        /// This method is used to evaluate the employee wage for multiple companies.
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWokingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        /// <returns>totalEmpWage</returns>
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWokingDays, int maxHoursPerMonth)
        {
            while (totalEmpHrs < maxHoursPerMonth &&
                    totalWorkingDays < numOfWokingDays)
            {
                totalWorkingDays++;
                Random rd = new Random();
                int empCheck = rd.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                    case IS_PART_TIME:
                    empHrs = 4;
                    break;
                    default:
                        empHrs = 0;
                    break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hr: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage for company " +company+ ":"+totalEmpWage);
            return totalEmpWage;
        }
    }
}
