namespace Interfaces_In_C_
{

    /// <summary>
    /// By Default all methods of interface are abstract and public
    /// don't allow explicit access modifiers 
    /// cannot have variables
    /// </summary>
    interface IEmployee
    {
        void Show();
    }

    class PartTimeEmp : IEmployee
    {
        public void Show()
        {
            Console.WriteLine("IEmployee interface");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface can have reference 
            // We cannot create or instantiate the interface
            IEmployee Emp = new PartTimeEmp();

           // emp = new PartTimeEmp();
            Emp.Show();
        }
    }
}