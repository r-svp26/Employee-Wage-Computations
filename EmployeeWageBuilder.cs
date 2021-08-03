using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder : IEmployeeWageComputation
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

        public List<EmployeeWageComputation> companyEmpWageList = new List<EmployeeWageComputation>();
        public Dictionary<string, EmployeeWageComputation> companyEmpWageMap = new Dictionary<string, EmployeeWageComputation>();

        /// <summary>
        /// evaluate the company wage. 
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) 
        {
            EmployeeWageComputation companyEmpWage = new EmployeeWageComputation(company,empRatePerHour,numOfWorkingDays,maxHoursPerMonth);
            companyEmpWageList.Add(companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (EmployeeWageComputation companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.Result());
            }
        }
            /// <summary>
            /// This method is used to evaluate the employee wage for multiple companies.
            /// </summary>
            public int  ComputeEmpWage(EmployeeWageComputation employeeWageComputation)
        {
            while (totalEmpHrs <  employeeWageComputation.maxHoursPerMonth &&
                    totalWorkingDays < employeeWageComputation.numOfWorkingDays)
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
            totalEmpWage = totalEmpHrs * employeeWageComputation.empRatePerHour;
            Console.WriteLine("Total Wage:" + totalEmpWage);
            return totalEmpWage;
        }
        public int GetTotalWage(string company)
        {
            {
               return this.companyEmpWageMap[company].totalWage;
            }
        }
    }
}
