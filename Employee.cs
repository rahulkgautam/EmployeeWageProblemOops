using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    class Employee
    {
        public int empRatePerHrs,numberOfWorkingDays, maxHrsInMonth;
        public Employee(int empRatePerHrs,int numberOfWorkingDays,int maxHrsInMonth)
        {
            this.empRatePerHrs = empRatePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
    }
}
