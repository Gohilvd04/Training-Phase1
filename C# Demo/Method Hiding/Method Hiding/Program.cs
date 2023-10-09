namespace Method_Hiding
{

    class Parent
    {
        public void show()
        {
            Console.WriteLine("Method class Parent");
        }
    }
    class Child : Parent
    {
        public void show()
        {
            base.show();
            Console.WriteLine("Method class Child");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            //Parent p = new Parent();
            //Parent pc = new Child();

            c.show();
            //p.show();
            //pc.show();

            //Console.WriteLine();
        }
    }

    class St
    {
        public static int a = 1;
        public static int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }
}