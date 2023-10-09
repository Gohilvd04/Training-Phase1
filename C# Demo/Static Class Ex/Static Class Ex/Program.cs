namespace Static_Class_Ex
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            // Console.WriteLine(Ab.GetAPlusB());

            DerivedClass dc = new DerivedClass();
            Program p = new Program();
            p.Show1();
        }

        public void Show()
        {
            Console.WriteLine("Hello class...");
        }
        public void Show1()
        {
            Show();
        }        
    }

    //public class Ab
    //{
    //    public static int a = 1;

    //    public static int b = 2;

    //    public static int GetAPlusB()
    //    {
    //        return a+b;
    //    }
    //}

    public class BaseClass
    {
        public int a;

        public BaseClass(int a)
        {
            this.a = a;
            Console.WriteLine("a is set to the given value!!!!!!!!{0}",a);
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass():base(6)
        {
            Console.WriteLine("This is constructor of Derived Class!!!!");
        }
    }
}