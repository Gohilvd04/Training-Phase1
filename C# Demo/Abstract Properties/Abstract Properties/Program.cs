namespace Abstract_Properties
{


    abstract class Person
    {
        public abstract uint Id { get; set; }
        public abstract string Name { get; set; }
    }

    class Student : Person
    {

        uint SudentId;
        string StudentName;

        public override uint Id
        {

            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Student Id cannot be Zero!!");
                }
                else
                {
                    SudentId = value;
                }
            }
            get { return SudentId; }
        }

        public override string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be Null or Empty");
                }
                else
                {
                    StudentName = value;
                }
            }
            get { return StudentName; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "";
            student.Id = 0;

            Console.WriteLine(student.Id);
        }
    }

}