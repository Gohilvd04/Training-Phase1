namespace Anonymous_Function
{

    // we can use anonymous function with delegates
    // without delegates we cannot use anonymous function....

    /// <summary>
    /// Delegate for anonymous method
    /// </summary>
    /// <param name="a"></param>
    public delegate void MyDelegate(int a);

    internal class Program
    {
        public static void Meth(MyDelegate del, int a)
        {
            
            Console.WriteLine("A in meth method before del : "+ a);
            a += 10;
            del(a);

        }
        static void Main(string[] args)
        {
            /*
             * Method without name is called anonymous method 
             * can be defined using delegate keyword 
             * it is introduced in c# 2.0 version
             * can be assign to object of delegate type
             * no need to specify return type, we can return value using return keyword with return type of delegate
             * we cannot use access modifiers with anonymous method
             * cannot contain jump statements like go to, break, continue..
             * cannot access ref or out parameter of outer method
             * Delegates allow methods to be passed as parameters
             * can be used as event handler
             */


            //MyDelegate md = delegate (int a)
            //{
            //    a += 10;
            //    Console.WriteLine(a);
            //};

            //int a = 5;
            //md(a);
            //Console.WriteLine(a);

            Meth(delegate (int a){ a += 10; Console.WriteLine(a); },5);
        }
    }
}