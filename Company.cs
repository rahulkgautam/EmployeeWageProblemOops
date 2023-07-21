using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    public class Company
    {
        
        public string companyName;
        public int numberOfWorkingDays, maxHrsInMonth, empRatePerHrs,totalWage;
        public Company(string company,int empRatePerHrs,int numberOfWorkingDays,int maxHrsInMonth)
        {
            this.companyName = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
        public int GetTotalWage(string company)
        {
            if(companyName == company)
            return totalWage;
            return 0;
        }

    }
}
