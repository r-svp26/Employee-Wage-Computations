using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder employeeWageBuilderDMart = new EmployeeWageBuilder("DMart", 20, 2, 10);
            int dMartWage= employeeWageBuilderDMart.ComputeEmpWage();
            Console.WriteLine("DMart Total Wage:" + dMartWage);
            EmployeeWageBuilder employeeWageBuilderReliance = new EmployeeWageBuilder("Reliance", 10, 4, 20);
            int relianceWage= employeeWageBuilderReliance.ComputeEmpWage();
            Console.WriteLine("Reliance Total Wage:" + relianceWage);
        }
    }
}
