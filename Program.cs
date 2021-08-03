﻿using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
            employeeWageBuilder.AddCompanyEmpWage("DMart", 20, 10, 4);
            employeeWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 5);
            employeeWageBuilder.ComputeEmpWage();
        }
    }
}
