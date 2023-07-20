using System;

namespace EmpoyeeWageProblemDay8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome Employee Wage Problem using oops");
            var company = new EmployeeWageBuilder();
            company.AddCompanyObjectIntoArray("Google", 20, 20, 100);
            company.AddCompanyObjectIntoArray("Microsoft", 30, 30, 25);
            //employee.AddEmployee("Microsoft",30, 30, 25);
            //employee.AddEmployee("BridgeLab", 70, 31, 180);

        }
    }
}
