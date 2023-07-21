using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    class EmployeeWageBuilder
    {
        //public Company[] companies;
        public List<Company> ListOfCompanies;
        public int numberOfCompany = 0;

        public EmployeeWageBuilder()
        {
            //this.companies = new Company[5];
            ListOfCompanies = new List<Company>();
        }
        public void AddCompanyObjectIntoList(string companyName, int numberOfWorkingDays, int maxWorkingHrs, int empRatePerHr)
        {
            Company obj = new Company(companyName, numberOfWorkingDays, maxWorkingHrs, empRatePerHr);
            //companies[numberOfCompany] = obj;
            ListOfCompanies.Add(obj);
            // numberOfCompany++;
            //CalculateEmployeeDailyWage(obj);
        }
        public void IterateOverList()
        {
            foreach (Company comp in ListOfCompanies)
            {
                if (comp != null)
                {
                    int totalWage = CalculateEmployeeDailyWage(comp);
                   // comp.SetTotalWage(totalWage);
                }
            }
        }

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        public static int CalculateEmployeeDailyWage(Company company)
        {
            int empHour = 0, totalWorkingDays = 0, totalEmpWage = 0, totalEmpHour = 0, dailyEmpWage = 0;
            Random rdm = new Random();
            while (totalEmpHour <= company.maxHrsInMonth && totalWorkingDays < company.numberOfWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = rdm.Next(3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalEmpHour += empHour;
                dailyEmpWage = empHour * company.empRatePerHrs;
                Console.Write(dailyEmpWage+" ");
            }
            totalEmpWage = totalEmpHour * company.empRatePerHrs;
            Console.WriteLine("Daily Wage \nCompany Name :- " + company.companyName + " ,Total Emp Hrs " + totalEmpHour + " TotoEmpWage, " + totalEmpWage);
            return totalEmpWage;
        }
    }
}
