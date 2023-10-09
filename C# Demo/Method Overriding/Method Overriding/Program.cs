using System.Diagnostics.Tracing;

namespace Method_Overriding
{

    class Parent
    {

        //virtual keyword in method overriding 
        public virtual void show()
        {
            Console.WriteLine("Method of Parent class");
        }
    }

    class Child:Parent {

        // override keyword in method overriding 
        public override void show()
        {
            Console.WriteLine("Method of Child class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();//Though reference of parent object call the method of child class
            p.show();
        }
    }
}