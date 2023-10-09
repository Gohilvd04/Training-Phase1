namespace Value_Type_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.age = 20;
            emp.salary = 10000;

            Emp emp2 = emp;
            Emp emp3 = emp;

            emp.age = 10;

            Console.WriteLine("Employee 2 Age: "+ emp2.age);    // Example of Value type 
            Console.WriteLine("Employee 3 Age: "+ emp3.age);    // Output : 20 ...... Though we change the age of emp 
            Console.WriteLine("Employee Age: " + emp.age);   //  bcz it's value type different object for each employee is created no refrence is given
        }
    }
    struct Emp
    {
        public int salary;
        public int age;
    };
}