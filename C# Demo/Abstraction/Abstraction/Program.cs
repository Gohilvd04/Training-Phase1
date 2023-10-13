using System.Reflection.Metadata;

namespace Abstraction
{

    // Abstraction is the process of hiding implementation details from user,
    //Only the functionality will be provided
    // What it does is important instead of How it does

    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        public double TaxDeduction = 0.1;
        public double NetSalary;

        public Employee(int Id, string Name, double Gross)
        {
            EmpId = Id;
            EmpName = Name;
            GrossPay = Gross;

        }

        void CalculateSalary()
        {
            if(GrossPay >= 30000)
            {
                NetSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Salary: {0}", NetSalary);
            }
            else
            {
                Console.WriteLine("Salary : {0} ", GrossPay);
            }
        }

        public void ShowSalary()
        {
            CalculateSalary();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Vishal", 5000);
            emp.ShowSalary();

        }
    }
}