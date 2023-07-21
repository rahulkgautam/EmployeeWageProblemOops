using System;

namespace EmpoyeeWageProblemDay8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome Employee Wage Problem using oops");
            var company = new EmployeeWageBuilder();
            company.AddCompanyObjectIntoList("Google", 20, 20, 100);
            company.AddCompanyObjectIntoList("Microsoft", 30, 30, 25);
            company.IterateOverList();
            var totalWage =company.GetTotalWage("Microsoft");
            Console.WriteLine("Total Wage by Query :"+totalWage);
            
            //employee.AddEmployee("Microsoft",30, 30, 25);
            //employee.AddEmployee("BridgeLab", 70, 31, 180);

        }
    }
}
