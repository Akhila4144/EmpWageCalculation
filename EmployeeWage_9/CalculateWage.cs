using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage_9
{
   public class CalculateWage
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        public string Company;
        public int empRatePerHour;
        public int NumOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CalculateWage(String Company, int empRatePerHour, int NumOfWorkingDays, int maxHoursPerMonth)
        {
            this.Company = Company;
            this.empRatePerHour = empRatePerHour;
            this.NumOfWorkingDays = NumOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            int empHours = 0, totalEmpHours = 0, totalWorkingDays = 0;
            while (totalEmpHours <= this.maxHoursPerMonth && totalWorkingDays <= this.NumOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isPartTime:
                        empHours = 4;
                        break;

                    case isFullTime:
                        empHours = 8;
                        break;

                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHours += empHours;
            }
            totalEmpWage = totalEmpHours * empRatePerHour;
            //Console.WriteLine("total emp wage for company:" + Company + " is " + totalEmpWage);
        }
        public string toString()
        {
            return "total emp wage for company:" + this.Company + " is " + this.totalEmpWage;
        }
    }
}

    