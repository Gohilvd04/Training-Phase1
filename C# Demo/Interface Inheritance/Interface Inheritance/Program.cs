namespace Interface_Inheritance
{
    interface I1
    {
        void Show();
    }
    interface I2
    { 
        void Show();
    }

    interface I3
    {
        void Show();
    }
    interface I : I1, I2, I3
    {
        void Show();
    }

    class Multiple : I
    {
        public void Show()
        {
            Console.WriteLine("Multiple Method");
        }

       
    }

    class A
    {
        public static void Show()
        {
            Console.WriteLine("MEthod of A calss");
        }
    }
    class B : A
    {
        public static void Show()
        {
            Console.WriteLine("MEthod of B calss");
        }
    }

    class C : A
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            I2 m = new Multiple();
            m.Show();
        }
    }
}