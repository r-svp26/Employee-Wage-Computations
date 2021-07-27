using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage.ComputeEmpWage("WalMart", 30, 2, 10);
            EmployeeWage.ComputeEmpWage("Dmart", 20 , 2, 10);
            EmployeeWage.ComputeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
