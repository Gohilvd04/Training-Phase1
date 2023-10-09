namespace Sealed_Method
{

    class Parent
    {
        public virtual void show()
        {
            Console.WriteLine("Parent Method");
        }
    }

    class Child : Parent
    {

        // sealed method further cannot be override.....
         public sealed override void show()
        {
            Console.WriteLine("Child Method");
        }
    }

    class ChildGrand : Child
    {

        // we cannot override show method further because this method is sealed in Child class
        public void show()
        {
            Console.WriteLine("Hello GrandChild");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            ChildGrand c = new ChildGrand();

            c.show();
            
        }
    }
}