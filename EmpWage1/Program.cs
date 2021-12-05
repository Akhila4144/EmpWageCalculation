using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage1
{
   public class Program
    {
      public static void Main(string[] args)
        {
            int isFullTime = 1;
            int empRatePerHour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isFullTime)
            {
                //Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                //Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empRatePerHour * empHrs;
            Console.WriteLine("EmpWageDays:" + empWage);
            Console.ReadKey();
        }

        

    }
}
