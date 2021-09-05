using System;

namespace EmployeeWageCalculations
{
    class Employee
    {
        public const int IS_PRESENT_FULL_TIME = 1;
        public const int IS_PRESENT_HALF_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int WORK_DAYS_PER_MONTH = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < WORK_DAYS_PER_MONTH)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:  " + totalWorkingDays + "  Employee Working Hours: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage is:" + totalEmpWage);     
        }
    }


}
