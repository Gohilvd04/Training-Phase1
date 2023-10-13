namespace Abstract_Class
{

    abstract class Person
    {

        public int age;
        public string FirstName;
        public string LastName;
        public string Phone;

        public abstract void PrintDetails();

    }
    class Student: Person
    {
        public int fees;
        public long rollNumber;

        public override void PrintDetails()
        {
            string name = FirstName + " " + LastName;
            Console.WriteLine("Student name is : {0}", name);
            Console.WriteLine("Student Age is : {0}", age);
            Console.WriteLine("Student rollNumber is : {0}", rollNumber);
            Console.WriteLine("Student fees is : {0}", fees);
        }

    }

    class Teacher : Person
    {
        public int salary;
        public string qualification;

        public override void PrintDetails()
        {
            string name = FirstName + " " + LastName;
            Console.WriteLine("Teacher name is : {0}", name);
            Console.WriteLine("Teacher Age is : {0}", age);
            Console.WriteLine("Teacher Salary is : {0}", salary);
            Console.WriteLine("Teacher Qualification is : {0}", qualification);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student = new Student();
            student.FirstName = "Vishal";
            student.LastName = "Gohil";
            student.age = 22;
            student.fees = 10000;
            student.rollNumber = 45;

            student.PrintDetails();

            Console.WriteLine("......................................................");
            Teacher teacher = new Teacher();

            teacher.FirstName = "Vishal";
            teacher.LastName = "Gohil";
            teacher.age = 22;
            teacher.salary = 100000;
            teacher.qualification = "B.Tech";

            teacher.PrintDetails(); 
        }
    }
}