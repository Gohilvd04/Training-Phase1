using System.ComponentModel;

namespace Reference_Type_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.age = 1;
            emp.salary = 10;

            Emp emp1 = emp;
            Emp emp2 = emp;

            emp.age = 2; 
            emp1.salary = 20;

            Console.WriteLine("Age : " + emp.age);
            Console.WriteLine("Age 1: " + emp1.age);
            Console.WriteLine("Age 2: " + emp2.age);

        }
    }
    class Emp
    {
        public int age;
        public int salary;
    }
}