using System;

namespace EmployeeWage_9
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateWage Google = new CalculateWage("google", 20, 20, 100);
            CalculateWage infosys = new CalculateWage("infosys", 30, 25, 100);
            Google.ComputeEmpWage();
            Console.WriteLine(Google.toString());
            infosys.ComputeEmpWage();
            Console.WriteLine(infosys.toString());

        }
    }
}
