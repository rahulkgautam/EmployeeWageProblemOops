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
        public void PrintOutPutOfEmp(Employee empObject)
        {
            var calculateEmpWage = new EmployeeDailyWage();
            var empDetails = calculateEmpWage.CalculateEmployeeDailyWage(empObject);
            Console.WriteLine("Total Working Days: " + empDetails.TotalWorkingDays);
            Console.WriteLine("Total Working Hours: " + empDetails.TotalEmpHour);
            Console.WriteLine("Total Employee Wage : " + empDetails.TotalEmpWage);
        }
    }
}
