using System.Collections.Generic;

namespace S2_Ex1
{
    public class Company
    {
        private List<Employee> employees;

        public Company()
        {
            employees = new List<Employee>();
        }

        public double GetMonthlySalaryTotal()
        {
            double sum = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                sum += employees[i].GetMonthlySalary();
            }

            return sum;
        }

        public void HireNewEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}