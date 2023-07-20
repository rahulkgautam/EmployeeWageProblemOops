using System;

namespace EmpoyeeWageProblemDay8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome Employee Wage Problem using oops");
            var google = new EmployeeWageBuilder("Google", 20, 20, 100);
            google.PrintEmployeeDetails();

            var microsoft = new EmployeeWageBuilder("Microsoft", 30, 30, 25);
            microsoft.PrintEmployeeDetails();
            //employee.AddEmployee("Microsoft",30, 30, 25);
            //employee.AddEmployee("BridgeLab", 70, 31, 180);

        }
    }
}
