using System;

namespace EmpoyeeWageProblemDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeDailyWage();
            Console.WriteLine("Welcome Employee Wage Problem using oops");
            employee.AddEmployee("Google",20,20,100);
            employee.AddEmployee("Microsoft",30, 30, 25);
            employee.AddEmployee("BridgeLab", 70, 31, 180);

        }
    }
}
