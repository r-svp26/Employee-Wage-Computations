using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWageComputation
    {
        public string companyName;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalWage;
        /// <summary>
        /// This constructor is used to initialize the instance variable.
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="empRatePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursPerMonth"></param>
        public EmployeeWageComputation(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.companyName = companyName;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        /// <summary>
        /// set the totalEmpWage
        /// </summary>
        /// <param name="totalEmpWage"></param>
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalWage = totalEmpWage;
        }
        /// <summary>
        /// total emp wage for the company.
        /// </summary>
        /// <returns></returns>
        public string Result()
        {
            return "Total Employee wage for Comapny : " + this.companyName + " is " + this.totalWage;
        }
    }
}
