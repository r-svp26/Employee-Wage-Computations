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
        public int empHrs = 0;
        public int totalEmpHrs = 0;
        public int totalWorkingDays = 0;
        public int totalEmpWage = 0;
        public int numOfCompany = 0;
        /// <summary>
        /// array initialization.
        /// </summary>
        EmployeeWageComputation[] employeeWageComputation = new EmployeeWageComputation[3];
        /// <summary>
        /// evaluate the company wage
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void AddCompanyWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) 
        {
            employeeWageComputation[numOfCompany] = new EmployeeWageComputation()
            {
                CompanyName = company,
                EmpRatePerHour = empRatePerHour,
                NumOfWorkingDays = numOfWorkingDays,
                MaxHoursPerMonth = maxHoursPerMonth
            };
            numOfCompany++;
        }
        /// <summary>
        /// calculate total wage for company
        /// </summary>
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                employeeWageComputation[i].TotalEmpWage = ComputeEmpWage(employeeWageComputation[i]);
                Console.WriteLine(employeeWageComputation[i]);
            }
        }
        /// <summary>
        /// This method is used to evaluate the employee wage for multiple companies.
        /// </summary>
        public int  ComputeEmpWage(EmployeeWageComputation employeeWageComputation)
        {
            while (totalEmpHrs <  employeeWageComputation.MaxHoursPerMonth &&
                    totalWorkingDays < employeeWageComputation.NumOfWorkingDays)
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
            totalEmpWage = totalEmpHrs * employeeWageComputation.EmpRatePerHour;
            Console.WriteLine("Total Wage:" + totalEmpWage);
            return totalEmpWage;
        }
    }
}
