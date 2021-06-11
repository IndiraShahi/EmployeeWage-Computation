using System;

namespace Employeewage_computation
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject goldmann = new EmpWageBuilderObject("Goldmann Sachs", 800, 22, 176);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            goldmann.computeEmpWage();
            Console.WriteLine(goldmann.toString());
        }
    }
}
