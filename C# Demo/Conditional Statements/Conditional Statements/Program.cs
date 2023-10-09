using System.ComponentModel;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the User Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            if (userName == "Vd" || password =="Rv" ) {
                Console.WriteLine("Login Successfully");
            }
            else
            {

                Console.WriteLine("Please enter valid username and password");
            }

            Console.WriteLine("Sum :" + Add(6, 7));
            Console.WriteLine("Sum :" + new Program().sub(6, 7));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public int sub (int a, int b) {  return a - b; }
    }
}