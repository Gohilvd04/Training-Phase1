namespace Static_Properties
{

    class University
    {
        static string universityName;
        static string DeptName;

        public static string _universityName
        {
            set
            {
                universityName = value;
            }

            get
            {
                return universityName;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            University._universityName = "GTU";
            Console.WriteLine(University._universityName);

        }
    }
}