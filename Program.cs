using System;

namespace EmployeeWageCalculations
{
    class Employee
    {
        static void Main(string[] args)
        {
            int IS_PRESENT_FULL_TIME = 1;
            int IS_PRESENT_HALF_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_PRESENT_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_PRESENT_HALF_TIME)
            {
                empHrs = 4;
            }
            else 
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employee Wage is:" + empWage);
        }
    }
}
