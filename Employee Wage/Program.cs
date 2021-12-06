using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int isFullTime = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck==isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
                 Console.ReadKey();
            }
        }
    }
}
