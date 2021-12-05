using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empWage3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empHrs = 0;
            int empRatePerHr = 20;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;

            }
            if (empCheck == isPartTime)
            {
                Console.WriteLine("Employee doing parttime");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }

            empWage = empHrs * empRatePerHr;
            Console.WriteLine("EmpWageDays:" + empWage);
            Console.ReadKey();

        }


    }
}
