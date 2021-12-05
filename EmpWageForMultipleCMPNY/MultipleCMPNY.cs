using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageForMultipleCMPNY
{
   public class MultipleCMPNY
    {
        int isFullTime = 1;
        int isPartTime = 2;
        public int calculateEmpWage(String company, int empRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth)
        {
            int empHours = 0, totalEmpHours = 0, totalWorkingDays = 0;
            while (totalEmpHours <= MaxHoursPerMonth && totalWorkingDays < NumOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHours = 8;
                        break;

                    case 2:
                        empHours = 4;
                        break;

                    default:
                        empHours = 0;
                        break;

                }
                totalEmpHours += empHours;
            }
            int totalEmpwage = totalEmpHours * empRatePerHour;
            Console.WriteLine("Total emp wage=" + totalEmpwage);
            Console.WriteLine("EmpWageForCompany" + company);
            return totalEmpwage;
        }
    }
}
