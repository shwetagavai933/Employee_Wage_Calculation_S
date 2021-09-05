﻿using System;

namespace EmployeeWageCalculations
{
    class Employee
    {
        public const int IS_PRESENT_FULL_TIME = 1;
        public const int IS_PRESENT_HALF_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case IS_PRESENT_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PRESENT_HALF_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employee Wage is:" + empWage);
        }
    }
}
