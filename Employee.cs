using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    class Employee
    {
        public string companyName;
        public int numberOfWorkingDays, maxHrsInMonth, empRatePerHrs;
        public Employee(string company,int empRatePerHrs,int numberOfWorkingDays,int maxHrsInMonth)
        {
            this.companyName = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        public void PrintEmployeeDetails(Employee empObject)
        {
            var calculateEmpWage = new EmployeeDailyWage();
            var empDetails = calculateEmpWage.CalculateEmployeeDailyWage(empObject);
            Console.WriteLine("Company Name : " + empDetails.CompanyName);
            Console.WriteLine("Total Working Days: " + empDetails.TotalWorkingDays);
            Console.WriteLine("Total Working Hours: " + empDetails.TotalEmpHour);
            Console.WriteLine("Total Employee Wage : " + empDetails.TotalEmpWage);
        }
    }
}
