using System;

namespace EmpWageForMultipleCMPNY
{
   public class Program
    {
       public static void Main(string[] args)
        {
            MultipleCMPNY obj1 = new MultipleCMPNY();
            obj1.calculateEmpWage("DMart",20, 2, 10);
            obj1.calculateEmpWage("TCS", 20, 10, 20);
        }
    }
}
