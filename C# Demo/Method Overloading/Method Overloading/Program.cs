namespace Method_Overloading
{
    internal class Program
    {

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 6, 1));
        }
    }
}