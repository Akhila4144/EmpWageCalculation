using System;

namespace EmpWageWithConditions
{
    class Program
    {
        static void Main(string[] args)
        {

            int isFullTime = 1;
            int isPartTime = 2;
            int empWage = 0;
            int empHrs = 0;
            int empRatePerHr = 20;
            int Max_Working_Hr_Per_Month = 100;
            int Max_Working_Days_In_Month = 20;
            int Num_Working_Hr_Per_Month = 0;
            int Num_Working_Days_In_Month = 0;
            while ((Num_Working_Hr_Per_Month <= Max_Working_Hr_Per_Month && Num_Working_Days_In_Month <= Max_Working_Days_In_Month))
            {
                Num_Working_Days_In_Month++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                Num_Working_Hr_Per_Month += empHrs;
                empWage = empRatePerHr * Num_Working_Hr_Per_Month;
            }
            Console.WriteLine("Total employee Wage of reaching max Hrs and Days: " + empWage);
            Console.ReadKey();



        }

    }
}

