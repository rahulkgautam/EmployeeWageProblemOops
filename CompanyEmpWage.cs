﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    class CompanyEmpWage
    {
        
        public string companyName;
        public int numberOfWorkingDays, maxHrsInMonth, empRatePerHrs;
        public CompanyEmpWage(string company,int empRatePerHrs,int numberOfWorkingDays,int maxHrsInMonth)
        {
            this.companyName = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        
        public void PrintEmployeeDetails()
        {
            var calculateEmpWage = new EmployeeWageBuilder();
            var empDetails = calculateEmpWage.CalculateEmployeeDailyWage(companyName, empRatePerHrs,numberOfWorkingDays,maxHrsInMonth);
            Console.WriteLine("Company Name : " + empDetails.CompanyName);
            Console.WriteLine("Total Working Days: " + empDetails.TotalWorkingDays);
            Console.WriteLine("Total Working Hours: " + empDetails.TotalEmpHour);
            Console.WriteLine("Total Employee Wage : " + empDetails.TotalEmpWage);
        }
    }
}
