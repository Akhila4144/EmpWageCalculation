using System;

namespace EmpWage_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BuilderOfEmpWageArray builderOfEmpWageArray = new BuilderOfEmpWageArray();
            builderOfEmpWageArray.addcompanyEmpWage("Google", 20, 100, 50);
            builderOfEmpWageArray.addcompanyEmpWage("Reliance", 15, 50, 100);
            builderOfEmpWageArray.addcompanyEmpWage("Infosys", 20, 100, 50);
            builderOfEmpWageArray.ComputeEmpWage();
        }
    }
}
