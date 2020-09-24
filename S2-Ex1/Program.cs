using System;

namespace S2_Ex1
{
    public class Program
    {
        static void Main()
        {
            Company comp = new Company();
            Employee emp1 = new FullTimeEmployee("Steve", 500);
            Employee emp2 = new FullTimeEmployee("Bob", 1026);
            Employee emp3 = new PartTimeEmployee("Anne", 35, 20);
            
            comp.HireNewEmployee(emp1);
            comp.HireNewEmployee(emp2);
            comp.HireNewEmployee(emp3);
            Console.Out.WriteLine(comp.GetMonthlySalaryTotal());
        }
    }
}