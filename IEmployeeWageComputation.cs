using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public interface IEmployeeWageComputation
    {
        public void AddCompanyEmpWage(String company, int empRatePerHpur, int numOfWorkingDays, int maxHoursPerMonth);
        public void ComputeEmpWage();
    }
}
