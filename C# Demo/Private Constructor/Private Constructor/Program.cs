using System.Transactions;

namespace Private_Constructor
{
    internal class Program
    {

        Program()
        {
            Console.WriteLine("This is private constructor");
        }
        static void Main(string[] args)
        {
            Base bs = new Base();
            Sub sb = new Sub();

            Base.baseC();
           
          
            
        }
    }

    class Sub : Base
    {
        public Sub()
        {
            Console.WriteLine("This is private const from EX! classssssssssssss ");
        }

        public void subC()
        {
            Console.WriteLine("This is sub class method::::::::");
        }
    }

    class Base {
        public Base()
        {
            Console.WriteLine("This is private constructor from EX class:::<<<!!!!!!!!!!!");
        }

        public static void baseC()
        {
            Console.WriteLine("This is base class method;;;;;;;");
        }
    }

}