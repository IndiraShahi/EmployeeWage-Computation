using System;

namespace Employeewage_computation
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int Total_Working_Days = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage");
            
            int empHrs = 0;
            int empWage = 0;
            int TotalEmpWage = 0;
            for (int day = 1; day <= Total_Working_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                TotalEmpWage += empWage;
                Console.WriteLine("Employee wage:" + empWage);
            }
            Console.WriteLine("Total wage of employee :" + TotalEmpWage);
        }
    }
}
