using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder
    {
        // constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        // variables
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int empHrs = 0;
        public int totalEmpHrs = 0;
        public int totalWorkingDays = 0;
        public int totalEmpWage = 0;

        public EmployeeWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        /// <summary>
        /// This method is used to evaluate the employee wage for multiple companies.
        /// </summary>
        public int ComputeEmpWage()
        {
            while (totalEmpHrs < maxHoursPerMonth &&
                    totalWorkingDays < numOfWorkingDays)
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
            return totalEmpWage;
        }
    }
}
