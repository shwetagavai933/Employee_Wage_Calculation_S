﻿using System;

namespace EmployeeWageCalculations
{
    class Employee
    {
        static void Main(string[] args)
        {
            int IS_PRESENT_FULL_TIME = 1;

            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if (empCheck == IS_PRESENT_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
