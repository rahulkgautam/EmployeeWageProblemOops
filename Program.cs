using System;

namespace EmpoyeeWageProblemDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeDailyWage();
            Console.WriteLine("Welcome Employee Wage Problem using oops");
            employee.AddEmployeeObject(20,20,100);
            employee.AddEmployeeObject(70, 31, 180);

        }
    }
}
