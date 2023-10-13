namespace Lambda_Expression
{

    public delegate void MyDel(int num);
    internal class Program
    {
        static void Main(string[] args)
        {

             /*
              * Lambda expression introduce in 3.0
              * It simplifies anonymous function........ shorthand for anonymous function
              * does not require to specify the data type of parameter
             */

            MyDel obj = (a) => {
                a += 5;
                Console.WriteLine(a);
            };

            obj(5);
        }
    }
}