using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
            employeeWageBuilder.AddCompanyWage("DMart", 20, 10, 2);
            employeeWageBuilder.AddCompanyWage("Reliance", 10, 4, 2);
            employeeWageBuilder.ComputeEmpWage();
        }
    }
}
