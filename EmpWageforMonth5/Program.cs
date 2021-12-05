using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageforMonth5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int empRatePerHr = 20;
            int Max_Working_Days_Per_Month = 20;
            for (int day = 0; day <= Max_Working_Days_Per_Month; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                if (empCheck == isFullTime)
                {
                    empHrs = 8;
                    Console.WriteLine("Employee is Present");
                }
               else if (empCheck == isPartTime)      
                {
                    empHrs = 4;
                    Console.WriteLine("Employee is doing partTime");
                }
                else
                {
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                }

                empWage = empHrs * empRatePerHr;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            Console.ReadKey();
        }




    }
} 
    