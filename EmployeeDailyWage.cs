using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    class EmployeeDailyWage
    {
        public EmployeeModel employeeModels;
        public EmployeeModel CalculateEmployeeDailyWage(string company, int empRatePerHrs, int numberOfWorkingDays, int maxHrsInMonth)
        {
            employeeModels = new EmployeeModel();
            int totalWorkingDays = 0, totalWorkingHrs = 0, empHour = 0,empWage = 0,totalEmpWage = 0,totalEmpHour = 0;
            Random rdm = new Random();
            while (totalWorkingDays <numberOfWorkingDays&& totalWorkingHrs< maxHrsInMonth)
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
                if (maxHrsInMonth > totalEmpHour)
                {
                    totalEmpHour += empHour;
                    empWage = empHour * empRatePerHrs;
                    totalEmpWage += empWage;
                }
            }
            employeeModels.CompanyName = company;
            employeeModels.TotalWorkingDays= totalWorkingDays;
            employeeModels.TotalEmpWage = totalEmpWage;
            employeeModels.TotalEmpHour = totalEmpHour;
            return employeeModels;
        }
    }
}
