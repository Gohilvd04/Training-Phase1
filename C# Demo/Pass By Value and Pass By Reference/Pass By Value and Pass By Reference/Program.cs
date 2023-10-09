namespace Pass_By_Value_and_Pass_By_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            PassByOut(out value);
            Console.WriteLine("Value from actual parameter: {0} ",value);
        }
        static void PassByValue(int value)
        {
            value += 10;
            Console.WriteLine("Value from pass by value function : {0} ", value);
        }
        
        static void PassByRef(ref int value)
        {
            value += 10;
            Console.WriteLine("Value from pass by reference function : {0} ", value);
        }

        static void PassByOut(out int value)
        {
            value = 5;
            Console.WriteLine("Value from Pass By Out Function : {0}", value);
        }
    }
}