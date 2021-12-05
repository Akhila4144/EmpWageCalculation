using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingSwitch
{
    public class Program
    {
    

        public static void Main(string[] args)
        {
            int isFullTime=1;
            int isPartTime=2;
            int empHrs = 0;
            int empRatePerHr = 20;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Emp is present");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Emp doing partTime");
                    break;
                default:
                   empHrs = 0;
                    Console.WriteLine("Emp is absent");
                    break;
            }     
             empWage = empHrs * empRatePerHr;
            Console.WriteLine("EmpWageDays:" + empWage);
            Console.ReadKey();




            
            }
       

        }

    }
