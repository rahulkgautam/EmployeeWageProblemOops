using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoyeeWageProblemDay8
{
    public class Company
    {
        
        public string companyName;
        public int numberOfWorkingDays, maxHrsInMonth, empRatePerHrs;
        public Company(string company,int empRatePerHrs,int numberOfWorkingDays,int maxHrsInMonth)
        {
            this.companyName = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
       
    }
}
