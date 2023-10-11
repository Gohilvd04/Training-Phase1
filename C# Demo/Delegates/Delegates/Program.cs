namespace Delegates
{

    /// <summary>
    /// Delegates are reference to the method.
    /// it is used to encapsulate the method 
    /// there are 3 types of delegates
    /// single cast, multi cast and multiple delegates
    /// single cast: point to the single method
    /// multiple: multiple delegates can be define to poin multiple methods 
    /// multi cast: single delegate can wrap multiple methods... +=,-= are used
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>

    public delegate void Calculation(int a, int b);
    //public delegate void IncDcr(int a);
    //public delegate void DelegateShow();


    internal class Program
    {
        static void Addition(int a, int b)
        {
            Console.WriteLine("Sum : {0}", a + b);
        }
        
        static void Substraction(int a, int b)
        {
            Console.WriteLine("Sub : {0}", a - b);
        }static void Multiplication(int a, int b)
        {
            Console.WriteLine("Mul : {0}", a * b);
        }static void Division(int a, int b)
        {
            Console.WriteLine("Div : {0}", a / b);
        }
        static void Main(string[] args)
        {

            Calculation obj = new Calculation(Program.Addition);

            //Multi cast delegate using +=, -=

            obj += Substraction; 
            obj += Multiplication;
            obj += Division;
            obj -= Multiplication;

            obj(5, 3);

            //obj = Substraction;
            //obj(5, 3);

            //obj = Multiplication;
            //obj(5, 3);
            
            //obj = Division;
            //obj(5, 3);
        }
    }
}