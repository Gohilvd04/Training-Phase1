using System.Reflection.Metadata;

namespace Properties_Getters_Setters
{

    class Student
    {
        private int Id;
        private string Name;
        private int Age;

        public int IdProp
        {
            set
            {
                Id = value;
            }
            get
            {
                return Id;
            }
        }
        public string NameProp
        {
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name is required");
                }
                else
                {
                    Name = value; 
                }
            }
            get { return Name; }
        }
        public int AgeProp
        {
            set { 
                if(value >= 0)
                {
                    Age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative");
                }
            }    
            get { return Age; }
        }

        public void getDetails()
        {
            Console.WriteLine("Name : {0},\nAge : {1},\nId : {2}\n..........................", Name,Age,Id);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(); ;

            st.IdProp = 1;
            st.NameProp = "";
            st.AgeProp = 20;

            st.getDetails();

            Student st1 = new Student();
            st1.IdProp = 2;
            st1.NameProp = "Cd";
            st1.AgeProp = -23;

            //st1.getDetails();
            
            Student st2 = new Student();
            st2.IdProp = 3;
            st2.NameProp = "Ld";
            st2.AgeProp = 43;

            st2.getDetails();
        }
    }
}