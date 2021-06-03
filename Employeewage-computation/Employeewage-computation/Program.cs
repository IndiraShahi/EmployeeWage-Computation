using System;

namespace Employeewage_computation
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_Working_Days = 20;
        public const int MAX_WORKING_HRS = 100;
        public static int ComputeEmpWage()
        {
            
            int empHrs = 0;
            int totalWorkingDays = 0;
            int TotalEmpHrs = 0;
            while(TotalEmpHrs <= MAX_WORKING_HRS && totalWorkingDays <= MAX_Working_Days) 
            {
                totalWorkingDays++;
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
                TotalEmpHrs += empHrs;
                Console.WriteLine("Working days:" + totalWorkingDays + "Employee working hours:" + empHrs);
            }
            int TotalEmpWage = TotalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total wage of employee :" + TotalEmpWage);
            return TotalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}
