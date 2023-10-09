namespace Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            float b = a;    //Implicit conversion
            float c = 2.444f;
            int n =(int) c;     //Explicit Conversion
            int x = Convert.ToInt32(c); //Explicit Conversion
            string s = "10";


            int sum = int.Parse(s) + a; //Explicit Conversion

            Console.WriteLine(a); 
            Console.WriteLine(sum); 

            Console.WriteLine("{0},{0},{2},{1}",c,b,c);
        }
    }
}