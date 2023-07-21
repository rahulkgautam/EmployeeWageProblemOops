using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    class EmployeeWageBuilder
    {
        public EmployeeModel employeeModels;
        public List<CompanyEmpWage> listOfCompanies;
        public int numberOfCompany = 0;

        public EmployeeWageBuilder()
        {
            listOfCompanies = new List<CompanyEmpWage>();
        }
        public void IterateOverList()
        {
            foreach (var comp in listOfCompanies)
            {
                if (comp != null)
                {
                    var totalWage = CalculateEmployeeDailyWage(comp);
                    PrintEmployeeDetails(totalWage);
                }
            }
        }
        public void AddCompanyObjectIntoList(string company, int empRatePerHrs, int numberOfWorkingDays, int maxHrsInMonth)
        {
            var obj = new CompanyEmpWage(company, empRatePerHrs, numberOfWorkingDays, maxHrsInMonth);
            listOfCompanies.Add(obj);
            //obj.PrintEmployeeDetails();
            //CalculateEmployeeDailyWage(obj);
        }
        public EmployeeModel CalculateEmployeeDailyWage(CompanyEmpWage company)
        {
            employeeModels = new EmployeeModel();
            int totalWorkingDays = 0, totalWorkingHrs = 0, empHour = 0,empWage = 0,totalEmpWage = 0,totalEmpHour = 0;
            Random rdm = new Random();
            while (totalWorkingDays <company.numberOfWorkingDays&& totalWorkingHrs< company.maxHrsInMonth)
            {
                totalWorkingDays++;
                int empCheck = rdm.Next(3);
                switch (empCheck)
                {
                    case 1:
                        empHour = 8;
                        break;
                    case 2:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                if (company.maxHrsInMonth > totalEmpHour)
                {
                    totalEmpHour += empHour;
                    empWage = empHour * company.empRatePerHrs;
                    totalEmpWage += empWage;
                }
            }
            employeeModels.CompanyName =company.companyName;
            employeeModels.TotalWorkingDays= totalWorkingDays;
            employeeModels.TotalEmpWage = totalEmpWage;
            employeeModels.TotalEmpHour = totalEmpHour;
            return employeeModels;
        }
        public void PrintEmployeeDetails(EmployeeModel empDetails)
        {
            Console.WriteLine("+++++++++++++=================+++++++++++++");
            Console.WriteLine("Company Name : " + empDetails.CompanyName);
            Console.WriteLine("Total Working Days: " + empDetails.TotalWorkingDays);
            Console.WriteLine("Total Working Hours: " + empDetails.TotalEmpHour);
            Console.WriteLine("Total Employee Wage : " + empDetails.TotalEmpWage);
        }
    }
}
