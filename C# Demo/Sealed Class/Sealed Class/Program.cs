namespace Sealed_Class
{

    sealed class BaseClass// Sealded keyword prevents the class being inherited
        //We cannot inherit sealed class.... It used to prevent the Data to be changed in the base class
    {
        public void show1()
        {
            Console.WriteLine("Method of base class");
        }
    }
    class DerivedClass 
    {
        public void show2()
        {
            Console.WriteLine("Method of base class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}