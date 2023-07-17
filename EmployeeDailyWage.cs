using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    class EmployeeDailyWage
    {
        public EmployeeModel employeeModels;
        int numberOfEmp = 1;
        public void AddEmployee(string companyName,int empRatePerHrs, int numberOfWorkingDays, int maxHrsInMonth)
        {
            var empObject = new Employee(companyName,empRatePerHrs, numberOfWorkingDays,maxHrsInMonth);
            Console.WriteLine("========Employee Added===== {0}", numberOfEmp);
            empObject.PrintEmployeeDetails(empObject);
            numberOfEmp++;
        }
        public EmployeeModel CalculateEmployeeDailyWage(Employee employee)
        {
            employeeModels = new EmployeeModel();
            int totalWorkingDays = 0, totalWorkingHrs = 0, empHour = 0,empWage = 0,totalEmpWage = 0,totalEmpHour = 0;
            Random rdm = new Random();
            while (totalWorkingDays <employee.numberOfWorkingDays&& totalWorkingHrs< employee.maxHrsInMonth)
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
                if (employee.maxHrsInMonth > totalEmpHour)
                {
                    totalEmpHour += empHour;
                    empWage = empHour * employee.empRatePerHrs;
                    totalEmpWage += empWage;
                }
            }
            employeeModels.CompanyName = employee.companyName;
            employeeModels.TotalWorkingDays= totalWorkingDays;
            employeeModels.TotalEmpWage = totalEmpWage;
            employeeModels.TotalEmpHour = totalEmpHour;
            return employeeModels;
        }
    }
}
