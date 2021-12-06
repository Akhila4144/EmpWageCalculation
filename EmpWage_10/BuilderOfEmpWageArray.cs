using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage_10
{
    public class BuilderOfEmpWageArray
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        private int NumOfCompanies = 0;
        private CompanyEmpWage[] calculateCompanyWageArray;

        public BuilderOfEmpWageArray()
        {
            this.calculateCompanyWageArray = new CompanyEmpWage[5];
        }
        public void addcompanyEmpWage(string company, int empRatePerHr, int NumOfWorkingDays, int MaxWorkingHrPerMonth)
        {
            calculateCompanyWageArray[this.NumOfCompanies] = new CompanyEmpWage(company, empRatePerHr, NumOfWorkingDays, MaxWorkingHrPerMonth);
            NumOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < NumOfCompanies; i++)
            {
                calculateCompanyWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.calculateCompanyWageArray[i]));
                Console.WriteLine(this.calculateCompanyWageArray[i].toString());
            }
        }

        public int ComputeEmpWage(CompanyEmpWage companyWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyWage.maxHoursPerMonth && totalWorkingDays < companyWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Employee Hours : " + empHrs);
                //Console.ReadLine();                
            }
            return totalEmpHrs * companyWage.empRatePerHour;
        }
    }
}




