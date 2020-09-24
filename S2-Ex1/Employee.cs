namespace S2_Ex1
{
    public abstract class Employee
    {
        public string Name;

        public abstract double GetMonthlySalary();

        public Employee(string name)
        {
            this.Name = name;
        }
    }
}